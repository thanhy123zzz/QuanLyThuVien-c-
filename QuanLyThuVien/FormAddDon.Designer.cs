
namespace QuanLyThuVien
{
    partial class FormAddDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIDsach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textsoluong = new System.Windows.Forms.TextBox();
            this.textIDkhach = new System.Windows.Forms.TextBox();
            this.textiddon = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textIDsach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textsoluong);
            this.groupBox1.Controls.Add(this.textIDkhach);
            this.groupBox1.Controls.Add(this.textiddon);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập ID \r\nsách mượn:";
            // 
            // textIDsach
            // 
            this.textIDsach.Location = new System.Drawing.Point(106, 258);
            this.textIDsach.Multiline = true;
            this.textIDsach.Name = "textIDsach";
            this.textIDsach.ReadOnly = true;
            this.textIDsach.Size = new System.Drawing.Size(310, 41);
            this.textIDsach.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập số\r\n lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập ID\r\n khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập ID đơn:";
            // 
            // textsoluong
            // 
            this.textsoluong.Location = new System.Drawing.Point(106, 184);
            this.textsoluong.Multiline = true;
            this.textsoluong.Name = "textsoluong";
            this.textsoluong.Size = new System.Drawing.Size(310, 41);
            this.textsoluong.TabIndex = 4;
            // 
            // textIDkhach
            // 
            this.textIDkhach.Location = new System.Drawing.Point(106, 110);
            this.textIDkhach.Multiline = true;
            this.textIDkhach.Name = "textIDkhach";
            this.textIDkhach.Size = new System.Drawing.Size(310, 41);
            this.textIDkhach.TabIndex = 3;
            // 
            // textiddon
            // 
            this.textiddon.Location = new System.Drawing.Point(106, 36);
            this.textiddon.Multiline = true;
            this.textiddon.Name = "textiddon";
            this.textiddon.Size = new System.Drawing.Size(310, 41);
            this.textiddon.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddDon_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIDsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsoluong;
        private System.Windows.Forms.TextBox textIDkhach;
        private System.Windows.Forms.TextBox textiddon;
    }
}