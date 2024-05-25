using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Class
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string connString;

        public static void Connect()
        {
            connString = "Data Source=DESKTOP-KQPQT81\\HATRONGCUONG;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            //MessageBox.Show("Kết nối thành công");
        }

        public static void Disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = new SqlCommand();
            data.SelectCommand.Connection = Class.Functions.conn;
            data.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, Class.Functions.conn);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSQL_Del(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được sử dụng, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }

        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, Class.Functions.conn);
            DataTable table = new DataTable();
            data.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Class.Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}