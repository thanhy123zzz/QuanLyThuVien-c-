using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class Dangnhapnhanvien : Form
    {
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public Dangnhapnhanvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            String IDnhanvien = textBox1.Text.Trim();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select *from nhanvien where IDnhanvien = '" + IDnhanvien + "'";

            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            try
            {
                if (reader.Read() && textBox2.Text.Trim() == "123456")
                {
                    String nameST = reader.GetString(1);
                    this.Close();
                    NhanVien a = new NhanVien(nameST, IDnhanvien);
                    a.ShowDialog();
                }
                else
                {
                    label4.Visible = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.Multiline = true;
            if (checkBox1.Checked == false)
                textBox2.Multiline = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
    }
}
