
namespace QuanLyThuVien
{
    partial class FormKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnameST = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTexit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTaddDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIDKH = new System.Windows.Forms.TextBox();
            this.CBkhachhang = new System.Windows.Forms.ComboBox();
            this.Btdrop = new System.Windows.Forms.Button();
            this.BTupdate = new System.Windows.Forms.Button();
            this.BTaddKH = new System.Windows.Forms.Button();
            this.BTsearch = new System.Windows.Forms.Button();
            this.textIDkhach = new System.Windows.Forms.TextBox();
            this.textIDnhanvien = new System.Windows.Forms.TextBox();
            this.textsoluong = new System.Windows.Forms.TextBox();
            this.textDON = new System.Windows.Forms.TextBox();
            this.listDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1101, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time: ";
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(151, 44);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(17, 20);
            this.textID.TabIndex = 12;
            this.textID.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Nhân Viên:";
            // 
            // textnameST
            // 
            this.textnameST.AutoSize = true;
            this.textnameST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnameST.Location = new System.Drawing.Point(151, 9);
            this.textnameST.Name = "textnameST";
            this.textnameST.Size = new System.Drawing.Size(17, 20);
            this.textnameST.TabIndex = 10;
            this.textnameST.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "___";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTexit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BTaddDon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textIDKH);
            this.groupBox1.Controls.Add(this.CBkhachhang);
            this.groupBox1.Controls.Add(this.Btdrop);
            this.groupBox1.Controls.Add(this.BTupdate);
            this.groupBox1.Controls.Add(this.BTaddKH);
            this.groupBox1.Controls.Add(this.BTsearch);
            this.groupBox1.Controls.Add(this.textIDkhach);
            this.groupBox1.Controls.Add(this.textIDnhanvien);
            this.groupBox1.Controls.Add(this.textsoluong);
            this.groupBox1.Controls.Add(this.textDON);
            this.groupBox1.Controls.Add(this.listDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 475);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý khách Hàng";
            // 
            // BTexit
            // 
            this.BTexit.Location = new System.Drawing.Point(1087, 96);
            this.BTexit.Name = "BTexit";
            this.BTexit.Size = new System.Drawing.Size(149, 29);
            this.BTexit.TabIndex = 24;
            this.BTexit.Text = "Thoát";
            this.BTexit.UseVisualStyleBackColor = true;
            this.BTexit.Click += new System.EventHandler(this.BTexit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(790, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(790, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID Đơn hàng:";
            // 
            // BTaddDon
            // 
            this.BTaddDon.BackColor = System.Drawing.Color.CadetBlue;
            this.BTaddDon.Location = new System.Drawing.Point(1087, 55);
            this.BTaddDon.Name = "BTaddDon";
            this.BTaddDon.Size = new System.Drawing.Size(149, 35);
            this.BTaddDon.TabIndex = 19;
            this.BTaddDon.Text = "Thêm đơn hàng";
            this.BTaddDon.UseVisualStyleBackColor = false;
            this.BTaddDon.Click += new System.EventHandler(this.BTaddDon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Các khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập ID \r\nkhách hàng: ";
            // 
            // textIDKH
            // 
            this.textIDKH.Location = new System.Drawing.Point(137, 52);
            this.textIDKH.Name = "textIDKH";
            this.textIDKH.Size = new System.Drawing.Size(361, 27);
            this.textIDKH.TabIndex = 16;
            // 
            // CBkhachhang
            // 
            this.CBkhachhang.FormattingEnabled = true;
            this.CBkhachhang.Location = new System.Drawing.Point(137, 97);
            this.CBkhachhang.Name = "CBkhachhang";
            this.CBkhachhang.Size = new System.Drawing.Size(468, 28);
            this.CBkhachhang.TabIndex = 15;
            this.CBkhachhang.SelectedIndexChanged += new System.EventHandler(this.CBkhachhang_SelectedIndexChanged);
            // 
            // Btdrop
            // 
            this.Btdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btdrop.Location = new System.Drawing.Point(1098, 418);
            this.Btdrop.Name = "Btdrop";
            this.Btdrop.Size = new System.Drawing.Size(138, 48);
            this.Btdrop.TabIndex = 14;
            this.Btdrop.Text = "Xóa";
            this.Btdrop.UseVisualStyleBackColor = true;
            this.Btdrop.Click += new System.EventHandler(this.Btdrop_Click);
            // 
            // BTupdate
            // 
            this.BTupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTupdate.Location = new System.Drawing.Point(933, 418);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(139, 48);
            this.BTupdate.TabIndex = 13;
            this.BTupdate.Text = "Sửa";
            this.BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTaddKH
            // 
            this.BTaddKH.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BTaddKH.Location = new System.Drawing.Point(1088, 16);
            this.BTaddKH.Name = "BTaddKH";
            this.BTaddKH.Size = new System.Drawing.Size(150, 33);
            this.BTaddKH.TabIndex = 12;
            this.BTaddKH.Text = "Thêm khách hàng";
            this.BTaddKH.UseVisualStyleBackColor = false;
            // 
            // BTsearch
            // 
            this.BTsearch.Location = new System.Drawing.Point(506, 52);
            this.BTsearch.Name = "BTsearch";
            this.BTsearch.Size = new System.Drawing.Size(99, 30);
            this.BTsearch.TabIndex = 11;
            this.BTsearch.Text = "Tìm Kiếm";
            this.BTsearch.UseVisualStyleBackColor = true;
            this.BTsearch.Click += new System.EventHandler(this.BTsearch_Click);
            // 
            // textIDkhach
            // 
            this.textIDkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDkhach.Location = new System.Drawing.Point(932, 211);
            this.textIDkhach.Multiline = true;
            this.textIDkhach.Name = "textIDkhach";
            this.textIDkhach.Size = new System.Drawing.Size(304, 37);
            this.textIDkhach.TabIndex = 10;
            // 
            // textIDnhanvien
            // 
            this.textIDnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDnhanvien.Location = new System.Drawing.Point(932, 284);
            this.textIDnhanvien.Multiline = true;
            this.textIDnhanvien.Name = "textIDnhanvien";
            this.textIDnhanvien.Size = new System.Drawing.Size(304, 37);
            this.textIDnhanvien.TabIndex = 7;
            // 
            // textsoluong
            // 
            this.textsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsoluong.Location = new System.Drawing.Point(932, 354);
            this.textsoluong.Multiline = true;
            this.textsoluong.Name = "textsoluong";
            this.textsoluong.Size = new System.Drawing.Size(304, 37);
            this.textsoluong.TabIndex = 6;
            // 
            // textDON
            // 
            this.textDON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDON.Location = new System.Drawing.Point(933, 138);
            this.textDON.Multiline = true;
            this.textDON.Name = "textDON";
            this.textDON.Size = new System.Drawing.Size(304, 37);
            this.textDON.TabIndex = 5;
            // 
            // listDon
            // 
            this.listDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listDon.FullRowSelect = true;
            this.listDon.GridLines = true;
            this.listDon.HideSelection = false;
            this.listDon.Location = new System.Drawing.Point(6, 138);
            this.listDon.Name = "listDon";
            this.listDon.Size = new System.Drawing.Size(769, 328);
            this.listDon.TabIndex = 1;
            this.listDon.UseCompatibleStateImageBehavior = false;
            this.listDon.View = System.Windows.Forms.View.Details;
            this.listDon.SelectedIndexChanged += new System.EventHandler(this.listDon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Đơn hàng";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID khách hàng";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID nhân viên";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 130;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 38);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quản Lý Khách Hàng";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 566);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnameST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textnameST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listDon;
        private System.Windows.Forms.Button BTaddKH;
        private System.Windows.Forms.Button BTsearch;
        private System.Windows.Forms.TextBox textIDkhach;
        private System.Windows.Forms.TextBox textIDnhanvien;
        private System.Windows.Forms.TextBox textsoluong;
        private System.Windows.Forms.TextBox textDON;
        private System.Windows.Forms.Button Btdrop;
        private System.Windows.Forms.Button BTupdate;
        private System.Windows.Forms.ComboBox CBkhachhang;
        private System.Windows.Forms.TextBox textIDKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTaddDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTexit;
    }
}