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
    public partial class FormThemNhom : Form
    {
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public FormThemNhom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            String IDnhom = textBox1.Text.Trim();
            String tennhom = textBox2.Text.Trim();

            {
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.CommandType = CommandType.Text;
                sqlcmd1.CommandText = "select * from nhomsach where IDnhom = '" +IDnhom + "'";
                sqlcmd1.Connection = sqlcon;
                SqlDataReader reader = sqlcmd1.ExecuteReader();
                if (IDnhom.Trim().StartsWith("nhom") == false || IDnhom.Trim().Substring(4).All(char.IsDigit) == false || IDnhom.Trim() == "" || IDnhom.Trim().Substring(4) == "")
                {
                    MessageBox.Show("ID nhóm sách không hợp lệ,Vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                if (reader.Read())
                {
                    MessageBox.Show("ID nhóm sách đã tồn tại, vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                reader.Close();
            } // trường hợp ID nhóm

            if(tennhom =="")
            {
                MessageBox.Show("Chưa nhập tên nhóm!");
                return;
            }    

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "insert into nhomsach values('" + IDnhom + "','" + tennhom + "')";

            sqlcmd.Connection = sqlcon;

            int kq = sqlcmd.ExecuteNonQuery();
            if(kq>0)
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
            } 

        }
    }
}
