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
    public partial class FormKhachHang : Form
    {
        String ten;
        String IDnhanvien;
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public FormKhachHang(String nameST, String IDnhanvien)
        {
            InitializeComponent();
            ten = nameST;
            this.IDnhanvien = IDnhanvien;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            textnameST.Text = ten;
            textID.Text = IDnhanvien;

            LoadCBkhachhang();
            LoadListDon();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void BTexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCBkhachhang()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select*from khachhang";
            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();

            while(reader.Read())
            {
                String idkhachhang = reader.GetString(0);
                String tenkhachhang = reader.GetString(1);
                int tongmuon = reader.GetInt32(2);

                String line = idkhachhang + " / " + tenkhachhang + " / " + tongmuon.ToString();
                CBkhachhang.Items.Add(line);
            }
            reader.Close();
        }
        private void LoadListDon()
        {
            listDon.Items.Clear();
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            if (CBkhachhang.SelectedIndex == -1)
            {
                sqlcmd.CommandText = "select * from don";

                sqlcmd.Connection = sqlcon;

                SqlDataReader reader = sqlcmd.ExecuteReader();

                while (reader.Read())
                {
                    String iddon = reader.GetString(0);
                    String idkhachhang = reader.GetString(1);
                    String idnhanvien = reader.GetString(2);
                    int soluong = reader.GetInt32(3);

                    ListViewItem lvi = new ListViewItem(iddon);
                    lvi.SubItems.Add(idkhachhang);
                    lvi.SubItems.Add(idnhanvien);
                    lvi.SubItems.Add(soluong.ToString());

                    listDon.Items.Add(lvi);
                }
                reader.Close();
            }
            else
            {
                String line = CBkhachhang.SelectedItem.ToString();
                String[] arr = line.Split('/');

                String idkhachhang = arr[0].Trim();

                sqlcmd.CommandText = "select*from don where IDkhachhang = '" + idkhachhang + "'";

                sqlcmd.Connection = sqlcon;

                SqlDataReader reader = sqlcmd.ExecuteReader();

                while(reader.Read())
                {
                    String iddon = reader.GetString(0);
                    //String idkhachhang = reader.GetString(1);
                    String idnhanvien = reader.GetString(2);
                    int soluong = reader.GetInt32(3);

                    ListViewItem lvi = new ListViewItem(iddon);
                    lvi.SubItems.Add(idkhachhang);
                    lvi.SubItems.Add(idnhanvien);
                    lvi.SubItems.Add(soluong.ToString());

                    listDon.Items.Add(lvi);
                }
                reader.Close();
            }    
        }

        private void listDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDon.SelectedItems.Count == 0) return;
            ListViewItem lvi = listDon.SelectedItems[0];
            textDON.Text = lvi.SubItems[0].Text.Trim();
            textIDkhach.Text = lvi.SubItems[1].Text.Trim();
            textIDnhanvien.Text = lvi.SubItems[2].Text.Trim();
            textsoluong.Text = lvi.SubItems[3].Text.Trim();
        }
        private void CBkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListDon();
        }

        private void BTsearch_Click(object sender, EventArgs e)
        {
            textIDKH.Text = textIDKH.Text.ToUpper();
            if(textIDKH.Text.StartsWith("CT")==false||textIDKH.Text.Trim().Substring(2).All(char.IsDigit)==false||textIDKH.Text == "")
            {
                MessageBox.Show("ID không hợp lệ vui lòng nhập lại!");
                return;
            }
            int a = CBkhachhang.FindString(textIDKH.Text.ToUpper());
            if(a==-1)
            {
                MessageBox.Show("Không tìm thấy id cần tìm!");
                textIDKH.Clear();
                return;
            }    
            CBkhachhang.SelectedIndex =a;
            LoadListDon();
        }

        private void BTaddDon_Click(object sender, EventArgs e)
        {
            FormAddDon a = new FormAddDon(IDnhanvien);
            a.ShowDialog();
            LoadListDon();
        }

        private void Btdrop_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            ListViewItem lvi = new ListViewItem();
            lvi = listDon.SelectedItems[0];
            String iddon = lvi.SubItems[0].Text;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
           
            sqlcmd.CommandText = "delete don where iddon ='" + iddon + "'";
            sqlcmd.Connection = sqlcon;

            if(sqlcmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Xóa thành công!");
                textDON.Text = "";
                textsoluong.Text = "";
                textIDkhach.Text = "";
                textIDnhanvien.Text = "";
                LoadListDon();
            }    
        }
    }
}
