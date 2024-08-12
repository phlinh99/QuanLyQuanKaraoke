namespace KaraokeNeeNee
{
    partial class CapNhatNV
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
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txthoT = new System.Windows.Forms.TextBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCV
            // 
            this.cbCV.FormattingEnabled = true;
            this.cbCV.Location = new System.Drawing.Point(158, 370);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(121, 24);
            this.cbCV.TabIndex = 43;
            this.cbCV.SelectedIndexChanged += new System.EventHandler(this.cbCV_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Chức vụ ";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(284, 431);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 35);
            this.btHuy.TabIndex = 41;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(120, 431);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(88, 35);
            this.btSave.TabIndex = 40;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(129, 223);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 39;
            this.date.Value = new System.DateTime(2024, 5, 11, 0, 0, 0, 0);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(158, 330);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(259, 22);
            this.txtSDT.TabIndex = 38;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(120, 295);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(297, 22);
            this.txtemail.TabIndex = 37;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(120, 258);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(297, 22);
            this.txtPW.TabIndex = 36;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(120, 188);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(297, 22);
            this.txtDC.TabIndex = 35;
            // 
            // txthoT
            // 
            this.txthoT.Location = new System.Drawing.Point(120, 152);
            this.txthoT.Name = "txthoT";
            this.txthoT.Size = new System.Drawing.Size(297, 22);
            this.txthoT.TabIndex = 34;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(120, 109);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(121, 24);
            this.cbGT.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Địa Chỉ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "CẬP NHẬT THÔNG TIN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "MaNV";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(120, 81);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(297, 22);
            this.txtma.TabIndex = 32;
            this.txtma.Click += new System.EventHandler(this.txtma_Click);
            // 
            // CapNhatNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 494);
            this.ControlBox = false;
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txthoT);
            this.Controls.Add(this.cbGT);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CapNhatNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatNV";
            this.Load += new System.EventHandler(this.CapNhatNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCV;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtPW;
        public System.Windows.Forms.TextBox txtDC;
        public System.Windows.Forms.TextBox txthoT;
        public System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtma;
    }
}