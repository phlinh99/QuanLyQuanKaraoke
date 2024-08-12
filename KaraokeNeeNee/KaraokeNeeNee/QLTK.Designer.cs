namespace KaraokeNeeNee
{
    partial class QLTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPNgay = new System.Windows.Forms.TabPage();
            this.cbThangg = new System.Windows.Forms.ComboBox();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDT2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbNam2 = new System.Windows.Forms.ComboBox();
            this.txtDT3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tPNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPNgay);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(45, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 587);
            this.tabControl1.TabIndex = 2;
            // 
            // tPNgay
            // 
            this.tPNgay.Controls.Add(this.cbThangg);
            this.tPNgay.Controls.Add(this.cbNgay);
            this.tPNgay.Controls.Add(this.label6);
            this.tPNgay.Controls.Add(this.txtDT);
            this.tPNgay.Controls.Add(this.label5);
            this.tPNgay.Controls.Add(this.dgv);
            this.tPNgay.Controls.Add(this.label2);
            this.tPNgay.Location = new System.Drawing.Point(4, 25);
            this.tPNgay.Name = "tPNgay";
            this.tPNgay.Padding = new System.Windows.Forms.Padding(3);
            this.tPNgay.Size = new System.Drawing.Size(1156, 558);
            this.tPNgay.TabIndex = 0;
            this.tPNgay.Text = "Thống Kê Theo Ngày";
            this.tPNgay.UseVisualStyleBackColor = true;
            // 
            // cbThangg
            // 
            this.cbThangg.FormattingEnabled = true;
            this.cbThangg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThangg.Location = new System.Drawing.Point(840, 20);
            this.cbThangg.Name = "cbThangg";
            this.cbThangg.Size = new System.Drawing.Size(121, 24);
            this.cbThangg.TabIndex = 7;
            this.cbThangg.SelectedIndexChanged += new System.EventHandler(this.cbThangg_SelectedIndexChanged);
            // 
            // cbNgay
            // 
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbNgay.Location = new System.Drawing.Point(275, 20);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(121, 24);
            this.cbNgay.TabIndex = 6;
            this.cbNgay.SelectedIndexChanged += new System.EventHandler(this.cbNgay_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập Tháng Cần Thống Kê: ";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(574, 490);
            this.txtDT.Multiline = true;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(182, 34);
            this.txtDT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 65);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1144, 387);
            this.dgv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Ngày Cần Thống Kê: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbNam);
            this.tabPage2.Controls.Add(this.cbThang);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDT2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê Theo Tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.cbNam.Location = new System.Drawing.Point(894, 24);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 24);
            this.cbNam.TabIndex = 14;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(359, 24);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 24);
            this.cbThang.TabIndex = 13;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập Năm Cần Thống Kê: ";
            // 
            // txtDT2
            // 
            this.txtDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT2.Location = new System.Drawing.Point(602, 497);
            this.txtDT2.Multiline = true;
            this.txtDT2.Name = "txtDT2";
            this.txtDT2.Size = new System.Drawing.Size(179, 35);
            this.txtDT2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng doanh thu:";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 63);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(1144, 405);
            this.dgv2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nhập Tháng Cần Thống Kê: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbNam2);
            this.tabPage3.Controls.Add(this.txtDT3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dgv3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1156, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống Kê Theo Năm ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbNam2
            // 
            this.cbNam2.FormattingEnabled = true;
            this.cbNam2.Items.AddRange(new object[] {
            "2023",
            "2024"});
            this.cbNam2.Location = new System.Drawing.Point(638, 20);
            this.cbNam2.Name = "cbNam2";
            this.cbNam2.Size = new System.Drawing.Size(121, 24);
            this.cbNam2.TabIndex = 13;
            this.cbNam2.SelectedIndexChanged += new System.EventHandler(this.cbNam2_SelectedIndexChanged);
            // 
            // txtDT3
            // 
            this.txtDT3.Location = new System.Drawing.Point(617, 500);
            this.txtDT3.Multiline = true;
            this.txtDT3.Name = "txtDT3";
            this.txtDT3.Size = new System.Drawing.Size(173, 37);
            this.txtDT3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tổng doanh thu:";
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(6, 63);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(1144, 415);
            this.dgv3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nhập Năm Cần Thống Kê: ";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(1102, 43);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 43);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 709);
            this.ControlBox = false;
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTK";
            this.Load += new System.EventHandler(this.QLTK_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPNgay.ResumeLayout(false);
            this.tPNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPNgay;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cbThangg;
        private System.Windows.Forms.ComboBox cbNgay;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDT2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbNam2;
        private System.Windows.Forms.TextBox txtDT3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Label label10;
    }
}