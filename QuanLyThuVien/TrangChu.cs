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
    public partial class TrangChu : Form
    {
        String strcon = @"Data Source=LAPTOP-3T1455IS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dangnhapnhanvien a = new Dangnhapnhanvien();
            a.ShowDialog();
        }
    }
}
