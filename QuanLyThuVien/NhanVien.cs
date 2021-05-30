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
using System.Globalization;

namespace QuanLyThuVien
{
    public partial class NhanVien : Form
    {
        String ten;
        String IDnhanvien;
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public NhanVien(String nameST, String IDnhanvien)
        {
            InitializeComponent();
            ten = nameST;
            this.IDnhanvien = IDnhanvien;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            textnameST.Text = ten;
            textID.Text = IDnhanvien;
           

            LoadListBooks();
            loadCBnhom();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void CBnhomSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            listView1.Items.Clear();
            if (CBnhomSach.SelectedIndex == -1) return;
            String line = CBnhomSach.SelectedItem.ToString();
            String[] arr = line.Split(':');
            String IDnhom = arr[1].Trim();
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books where idnhom='"+IDnhom+"'";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            while (reader1.Read())
            {
                
                DateTime ngaymuon;
                String IDkhachhang;
                String IDBook = reader1.GetString(0);
                ListViewItem liv = new ListViewItem(IDBook);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(IDnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(IDnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            reader1.Close();

        }
        private void LoadListBooks()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            while (reader1.Read())
            {
                DateTime ngaymuon;
                String IDkhachhang;
                String idnhom = reader1.GetString(4);
                String IDBook = reader1.GetString(0);
                ListViewItem liv = new ListViewItem(IDBook);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            reader1.Close();
        }
        private void LoadListBooksChuamuon()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books where trangthai=0";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            while (reader1.Read())
            {
                DateTime ngaymuon;
                String IDkhachhang;
                String idnhom = reader1.GetString(4);
                String IDBook = reader1.GetString(0);
                ListViewItem liv = new ListViewItem(IDBook);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            reader1.Close();
        }
        private void LoadListBooksDamuon()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books where trangthai=1";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            while (reader1.Read())
            {
                DateTime ngaymuon;
                String IDkhachhang;
                String idnhom = reader1.GetString(4);
                String IDBook = reader1.GetString(0);
                ListViewItem liv = new ListViewItem(IDBook);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            reader1.Close();
        }
        private void LoadListBooksQuaHan()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books where abs(month(getdate())-month(ngaymuon))>=1 or abs(year(getdate())-year(ngaymuon))>=1";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            while (reader1.Read())
            {
                DateTime ngaymuon;
                String IDkhachhang;
                String idnhom = reader1.GetString(4);
                String IDBook = reader1.GetString(0);
                ListViewItem liv = new ListViewItem(IDBook);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            reader1.Close();
        }    
        private void loadCBnhom()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd2 = new SqlCommand();
            sqlcmd2.CommandType = CommandType.Text;
            sqlcmd2.CommandText = "select*from nhomsach";

            sqlcmd2.Connection = sqlcon;
            SqlDataReader reader2 = sqlcmd2.ExecuteReader();
            while (reader2.Read())
            {
                String IDnhom = reader2.GetString(0);
                String tennhom = reader2.GetString(1);

                String line = tennhom + " :   " + IDnhom;
                CBnhomSach.Items.Add(line);
            }
            reader2.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (CBnhomSach.Text != "") CBnhomSach.Text = "";
            //if (CBnhomSach.SelectedValue.ToString()!="") CBnhomSach.Text = "";
            if (radioButton1.Checked == true)
            {
                LoadListBooks();
            }    
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            if(radioButton2.Checked==true)
            {
                LoadListBooksChuamuon();
            }    
        }
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
            listView1.Items.Clear();
            if (radioButton3.Checked == true)
            {
                LoadListBooksDamuon();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem lvi = listView1.SelectedItems[0];

            textIDsach.Text = lvi.SubItems[0].Text.Trim();
            textTenSach.Text = lvi.SubItems[1].Text;
            texttrangthai.Text = lvi.SubItems[2].Text;
            if (lvi.SubItems[3].Text != "null")
            {
                var d = DateTime.Parse(lvi.SubItems[3].Text, new CultureInfo("en-US", true));
                textngaymuon.Value = d;
            }
            else
            {
                textngaymuon.Value = DateTime.Now;
            }    
            textIDnhom.Text = lvi.SubItems[4].Text.Trim();
            textIDkhach.Text = lvi.SubItems[5].Text.Trim();

            dropBook.Enabled = true;
        }

        private void dropBook_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            XoaSach();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            listView1.Items.Clear();
            if (radioButton4.Checked == true)
            {
                LoadListBooksQuaHan();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        { 
            listView1.Items.Clear();
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String ID = textSearch.Text.Trim();

            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.Text;
            sqlcmd1.CommandText = "select*from books where IDsach = '" + ID + "'";

            sqlcmd1.Connection = sqlcon;
            SqlDataReader reader1 = sqlcmd1.ExecuteReader();
            if (reader1.Read())
            {
                DateTime ngaymuon;
                String IDkhachhang;
                String idnhom = reader1.GetString(4);
                
                ListViewItem liv = new ListViewItem(ID);

                String nameBook = reader1.GetString(1);
                liv.SubItems.Add(nameBook);

                bool trangthai = reader1.GetBoolean(2);
                liv.SubItems.Add(trangthai.ToString());
                if (trangthai)
                {
                    ngaymuon = reader1.GetDateTime(3);
                    IDkhachhang = reader1.GetString(5);

                    liv.SubItems.Add(ngaymuon.Date.ToShortDateString());
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add(IDkhachhang);
                }
                else
                {
                    liv.SubItems.Add("null");
                    liv.SubItems.Add(idnhom);
                    liv.SubItems.Add("null");
                }
                listView1.Items.Add(liv);
            } // load list books 
            else
            {
                MessageBox.Show("Không tìm thấy ID sách cần tìm!");
                return;
            }    
            reader1.Close();
            search.Enabled = false;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            search.Enabled = true;
            if(textSearch.Text=="")
            {
                search.Enabled = false;
            }    
        }

        private void textIDsach_TextChanged(object sender, EventArgs e)
        {
            if (textIDsach.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void textTenSach_TextChanged(object sender, EventArgs e)
        {
            if (textTenSach.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void texttrangthai_TextChanged(object sender, EventArgs e)
        {
            if (texttrangthai.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void textngaymuon_TextChanged(object sender, EventArgs e)
        {
            if (textngaymuon.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void textIDnhom_TextChanged(object sender, EventArgs e)
        {
            if (textIDnhom.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void textIDkhach_TextChanged(object sender, EventArgs e)
        {
            if (textIDkhach.Text != "") updateBook.Enabled = true;
            else updateBook.Enabled = false;
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            SuaSach();
        }
        private void SuaSach()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            if (textTenSach.Text == "") { MessageBox.Show("tên sách không để trống, mời nhập lại!"); return; }
            if(texttrangthai.Text.StartsWith("false") == false && texttrangthai.Text.StartsWith("true") == false) { MessageBox.Show("Trạng thái chỉ true hoặc false!");return; }
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
                }
                else
                {
                    if (textIDkhach.Text.StartsWith("null") == false)
                    {
                        MessageBox.Show("Sách chưa mượn, mời nhập 'null'!"); return;
                    }

                }
            } //trường hợp của id khách hàng
            String IDsach = textIDsach.Text.Trim();
            String tenSach = textTenSach.Text;
            bool trangthai = bool.Parse(texttrangthai.Text.Trim());
            String IDnhom = textIDnhom.Text.Trim();
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                if (trangthai == true)
                {
                    int trangthai1 = 1;

                    String IDkhach = textIDkhach.Text.Trim();
                    String ngaymuon = textngaymuon.Text.Trim();
                    sqlcmd.CommandText = "update books set IDsach = '" + IDsach + "', TenSach = N'" + tenSach + "', TrangThai =" + trangthai1 + " , ngaymuon = '" + ngaymuon + "', IDnhom = '" + IDnhom + "', IDKhachhang = '" + IDkhach + "' where IDsach = '" + IDsach + "'";
                }
                else
                {
                    int trangthai2 = 0;
                    String ngaymuon1 = "null";
                    String IDkhach1 = "null";
                    sqlcmd.CommandText = "update books set IDsach = '" + IDsach + "', TenSach = N'" + tenSach + "', TrangThai =" + trangthai2 + " , ngaymuon = " + ngaymuon1 + ", IDnhom = '" + IDnhom + "', IDKhachhang = " + IDkhach1 + " where IDsach = '" + IDsach + "'";


                }
                sqlcmd.Connection = sqlcon;

                int kq = sqlcmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    listView1.Items.Clear();
                    textIDsach.Text = "";
                    textIDkhach.Text = "";
                    textIDnhom.Text = "";
                    textTenSach.Text = "";
                    texttrangthai.Text = "";
                    textngaymuon.Text = "";
                    updateBook.Enabled = false;
                    if (radioButton1.Checked == true) LoadListBooks();
                    if (radioButton2.Checked == true) LoadListBooksChuamuon();
                    if (radioButton3.Checked == true) LoadListBooksDamuon();
                    if (radioButton4.Checked == true) LoadListBooksQuaHan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID sách cần sửa!");
                    updateBook.Enabled = false;
                    return;
                }
            } //
        }
        private void XoaSach()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String IDsach = textIDsach.Text.Trim();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            
            sqlcmd.CommandText = "delete books where idsach ='" + IDsach + "'";
            sqlcmd.Connection = sqlcon;
            int kq = sqlcmd.ExecuteNonQuery();
            if(kq>0)
            {
                MessageBox.Show("Xóa thành công");
                listView1.Items.Clear();
                textIDsach.Text = "";
                textIDkhach.Text = "";
                textIDnhom.Text = "";
                textTenSach.Text = "";
                texttrangthai.Text = "";
                textngaymuon.Text = "";
                dropBook.Enabled = false;
                if (radioButton1.Checked == true) LoadListBooks();
                if (radioButton2.Checked == true) LoadListBooksChuamuon();
                if (radioButton3.Checked == true) LoadListBooksDamuon();
                if (radioButton4.Checked == true) LoadListBooksQuaHan();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID sách cần Xóa!");
                return;
            }    
        }

        private void add_Click(object sender, EventArgs e)
        {
            FormThemSach a = new FormThemSach();
            a.ShowDialog();
            listView1.Items.Clear();
            if (radioButton1.Checked == true) LoadListBooks();
            if (radioButton2.Checked == true) LoadListBooksChuamuon();
            if (radioButton3.Checked == true) LoadListBooksDamuon();
            if (radioButton4.Checked == true) LoadListBooksQuaHan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThemNhom a = new FormThemNhom();
            a.ShowDialog();
            CBnhomSach.Items.Clear();
            loadCBnhom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKhachHang a = new FormKhachHang(ten,IDnhanvien);
            a.ShowDialog();
        }
    }
}
