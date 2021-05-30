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
    public partial class FormAddDon : Form
    {
        int sl;
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        String idnhanvien;
        public FormAddDon(String idnhanvien)
        {
            InitializeComponent();
            this.idnhanvien = idnhanvien;
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
            String iddon = textiddon.Text.Trim();
            String idkhach = textIDkhach.Text.Trim();
       
            if (textIDsach.ReadOnly == true)
            {
                {
                    if (iddon.StartsWith("don") == false || iddon.Substring(3).All(char.IsDigit) == false || iddon == "" || iddon.Substring(3) == "")
                    {
                        MessageBox.Show("ID đơn không hợp lệ, mời nhập lại"); return;
                    }
                    SqlCommand sqlcmd1 = new SqlCommand();
                    sqlcmd1.CommandType = CommandType.Text;
                    sqlcmd1.CommandText = "select *from don where IDDon = '" + iddon + "'";
                    sqlcmd1.Connection = sqlcon;

                    SqlDataReader reader = sqlcmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("ID đơn đã tồn tại vui lòng nhập lại!");
                        reader.Close();
                        return;
                    }
                    reader.Close();

                }//trường họp id đơn
                {
                    if (idkhach.StartsWith("CT") == false || idkhach.Substring(2).All(char.IsDigit) == false || idkhach == "" || idkhach.Substring(2) == "")
                    {
                        MessageBox.Show("Id khách hàng không hợp lệ vui lòng nhập lại!");
                        return;
                    }
                    SqlCommand sqlcmd2 = new SqlCommand();
                    sqlcmd2.CommandType = CommandType.Text;
                    sqlcmd2.CommandText = "select *from khachhang where IDkhachhang = '" + idkhach + "'";
                    sqlcmd2.Connection = sqlcon;

                    SqlDataReader reader = sqlcmd2.ExecuteReader();
                    if (reader.Read() == false)
                    {
                        MessageBox.Show("ID khách không tồn tại vui lòng nhập lại!");
                        reader.Close();
                        return;
                    }
                    reader.Close();
                } // trường hợp id khách
                String temp = textsoluong.Text.Trim();
                if(temp.All(char.IsDigit)==false||temp=="")
                {
                    MessageBox.Show("Số lượng không hợp lệ!");return;
                }
                int soluong = int.Parse(temp);

                sl = soluong;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "insert into don values('" + iddon + "','" + idkhach + "','" + idnhanvien + "'," + soluong + ")";

                sqlcmd.Connection = sqlcon;
                int kq = sqlcmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    textiddon.ReadOnly = true;
                    textIDkhach.ReadOnly = true;
                    textsoluong.ReadOnly = true;
                    button2.Enabled = false;
                    
                    textIDsach.ReadOnly = false;
                    MessageBox.Show("Thành công, mời nhập id sách!");
                    return;
                }

            }
            else
            {
                    String idsach = textIDsach.Text.Trim();
                    DateTime a = DateTime.Now;
                    String ngaymuon = a.ToShortDateString();
                int kq1=0;
                SqlCommand sqlcmd1 = new SqlCommand();
                if (kiemtraBook(idsach) == false)
                {
                    sqlcmd1.CommandType = CommandType.Text;
                    sqlcmd1.CommandText = "update books set TrangThai =" + 1 + " , ngaymuon = '" + ngaymuon + "', IDKhachhang = '" + idkhach + "' where IDsach = '" + idsach + "' ";

                    sqlcmd1.Connection = sqlcon;
                    kq1 = sqlcmd1.ExecuteNonQuery();
                }
                else kq1 = 1;
                if (kq1 > 0)
                {
                    if (sl == 1)
                    {
                        String temp = textsoluong.Text.Trim();
                        int soluong = int.Parse(temp);
                        MessageBox.Show("Tạo đơn hàng thành công!");
                        loadtongmuon(soluong, idkhach);
                        button2.Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        if (kiemtraBook(idsach))
                        {
                            MessageBox.Show("Sách đã mượn, hãy nhập sách khác!");
                        }        
                        else
                        {
                         MessageBox.Show("Thành công! Mời nhập ID sách tiếp theo!");
                         sl--; 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID sách sai! mời nhập lại từ đầu.");
                    SqlCommand sqlcmd2 = new SqlCommand();
                    sqlcmd2.CommandType = CommandType.Text;
                    sqlcmd2.CommandText = "delete don where iddon'" + iddon + "'";
                    sqlcmd2.Connection = sqlcon;
                    textiddon.ReadOnly = false;
                    textIDkhach.ReadOnly = false;
                    textsoluong.ReadOnly = false;
                    textIDsach.ReadOnly = true;
                    return;
                }
            }  
        }
        private void FormAddDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button2.Enabled == false)
            {
                e.Cancel = true;
            } 
        }
        private void loadtongmuon(int soluong , string idkhach)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "update khachhang set tongmuon = tongmuon + " + soluong + " where idkhachhang = '" + idkhach + "'";
            sqlcmd.Connection = sqlcon;
        }
        private bool kiemtraBook(String idsach)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select trangthai from books where idsach = '" + idsach + "'";
            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader.GetBoolean(0);
        }    
    }
}
