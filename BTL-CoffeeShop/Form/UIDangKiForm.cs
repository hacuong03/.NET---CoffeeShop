using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
namespace BTL_CoffeeShop
{
    public partial class UIDangKiForm : Form
    {   
       

        public SqlConnection connect =
            new SqlConnection(@"Server=NGUYENHAIXON\MSSQLSERVER2,1433;Database=QuanLyQuanCafe;Trusted_Connection=True");
        public UIDangKiForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regis_buttondangnhap_Click(object sender, EventArgs e)
        {
            UIDangNhapForm loginForm = new UIDangNhapForm();
            loginForm.Show();
            this.Hide();
        }

        private void regis_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            regis_password.PasswordChar = regis_showpassword.Checked ? '\0' : '*';
            regis_verpassword.PasswordChar = regis_showpassword.Checked ? '\0' : '*';
        }

        private bool emptyFields()
        {
            if (regis_username.Text == "" || regis_password.Text == ""|| regis_verpassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void regis_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM UserPass WHERE username = @usern";
                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern",regis_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = regis_username.Text.Substring(0, 1).ToUpper() +
                                             regis_username.Text.Substring(1);
                                MessageBox.Show(usern + " đã tồn tại", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else if (regis_password.Text != regis_verpassword.Text)
                            {
                                MessageBox.Show("Mật khẩu không giống nhau", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            } else if(regis_password.Text.Length < 8)
                            {
                                MessageBox.Show("Điền mật khẩu dài hơn 8 kí tự", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO UserPass (username, password, role, status, dateResgis) " +
                                                    "VALUES(@usern, @pass, @role, @status, @date)";
                                DateTime today = DateTime.Today;
                                
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", regis_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", regis_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", "Staff");
                                    cmd.Parameters.AddWithValue("@status", "Approve");
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    UIDangNhapForm loginForm = new UIDangNhapForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối dữ liệu thất bại" + ex , "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
            }
        }
    }
}