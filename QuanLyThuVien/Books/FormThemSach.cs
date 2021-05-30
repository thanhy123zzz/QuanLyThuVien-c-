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
    public partial class FormThemSach : Form
    {
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public FormThemSach()
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
                sqlcon.Open();
            {
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.CommandType = CommandType.Text;
                sqlcmd1.CommandText = "select * from books where IDsach = '" + textIDsach.Text.Trim() + "'";
                sqlcmd1.Connection = sqlcon;
                SqlDataReader reader = sqlcmd1.ExecuteReader();
                
                if (textIDsach.Text.Trim().StartsWith("book") == false || textIDsach.Text.Trim().Substring(4).All(char.IsDigit) == false || textIDsach.Text.Trim() == "" || textIDsach.Text.Trim().Substring(4)=="")
                {
                    MessageBox.Show("ID book không hợp lệ,Vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                if (reader.Read())
                {
                    MessageBox.Show("ID book đã tồn tại, vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                reader.Close();
            } // trường hợp của ID sách

            {
                if (textTenSach.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập tên sách!");
            }// trường hợp tên sách

            {
                if(texttrangthai.Text.StartsWith("false")==false&& texttrangthai.Text.StartsWith("true") == false)
                {
                    MessageBox.Show("Trạng thái chỉ có true hoặc false!");return;
                }    
            }// trường hợp của trạng thái

            {
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.CommandType = CommandType.Text;
                sqlcmd1.CommandText = "select * from nhomsach where IDnhom = '" + textIDnhom.Text.Trim() + "'";
                sqlcmd1.Connection = sqlcon;
                SqlDataReader reader = sqlcmd1.ExecuteReader();
                if (textIDnhom.Text.Trim().StartsWith("nhom") == false || textIDnhom.Text.Trim().Substring(4).All(char.IsDigit) == false || textIDnhom.Text.Trim() == "" || textIDnhom.Text.Trim().Substring(4) == "")
                {
                    MessageBox.Show("ID nhóm sách không hợp lệ,Vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                if (reader.Read() == false)
                {
                    MessageBox.Show("ID nhóm sách không tồn tại, vui lòng nhập lại!");
                    reader.Close();
                    return;
                }
                reader.Close();
            }// trường hợp của id nhóm

            {
                if (texttrangthai.Text.Trim() == "true")
                {
                    SqlCommand sqlcmd1 = new SqlCommand();
                    sqlcmd1.CommandType = CommandType.Text;
                    sqlcmd1.CommandText = "select*from khachhang where IDKhachHang = '" + textIDkhach.Text.Trim() + "'";
                    sqlcmd1.Connection = sqlcon;
                    SqlDataReader reader = sqlcmd1.ExecuteReader();

                    if (textIDkhach.Text.Trim().StartsWith("CT") == false || textIDkhach.Text.Trim().Substring(2).All(char.IsDigit) == false || textIDkhach.Text.Trim() == "" || textIDkhach.Text.Trim().Substring(2) == "")
                    {
                        MessageBox.Show("ID khách hàng không hợp lệ,Vui lòng nhập lại!");
                        reader.Close();
                        return;
                    }
                    if (reader.Read() == false)
                    {
                        MessageBox.Show("ID khách hàng không tồn tại, vui lòng nhập lại!");
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                else
                {
                    if (textIDkhach.Text.StartsWith("null") == false)
                    {
                        MessageBox.Show("Sách chưa mượn, mời nhập 'null'!"); return;
                    }

                }
            }//trường hợp của id khách hàng

            {
                String IDsach = textIDsach.Text.Trim();
                String tenSach = textTenSach.Text;
                bool trangthai = bool.Parse(texttrangthai.Text.Trim());
                String IDnhom = textIDnhom.Text.Trim();
                String IDkhach = textIDkhach.Text.Trim();
                DateTime d = textngaymuon.Value;
                String ngaymuon = d.ToShortDateString();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                if (trangthai == true)
                {
                    int trangthai1 = 1;

                    sqlcmd.CommandText = "insert into books values('" + IDsach + "',N'" + tenSach + "'," + trangthai1 + ",'" + ngaymuon + "','" + IDnhom + "','" + IDkhach + "')";
                }
                else
                {
                    int trangthai2 = 0;
                    String ngaymuon1 = "null";
                    String IDkhach1 = "null";
                    sqlcmd.CommandText = "insert into books values('" + IDsach + "',N'" + tenSach + "'," + trangthai2 + "," + ngaymuon1 + ",'" + IDnhom + "'," + IDkhach1 + ")";
                }
                sqlcmd.Connection = sqlcon;

                int kq = sqlcmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("thêm thành công");
                    this.Close();
                }
            }// thêm
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
