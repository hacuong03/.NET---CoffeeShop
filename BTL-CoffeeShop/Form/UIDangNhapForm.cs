using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CoffeeShop
{
    
    public partial class UIDangNhapForm : Form
    {
        public UIDangNhapForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_dangki_Click(object sender, EventArgs e)
        {
            UIDangKiForm regForm = new UIDangKiForm();
            regForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}