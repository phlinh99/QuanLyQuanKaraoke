namespace KaraokeNeeNee
{
    partial class QL_Đặt_Phòng
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datP = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSN = new System.Windows.Forms.ComboBox();
            this.cbLP = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btKD = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhtoanQL = new System.Windows.Forms.Button();
            this.btDP = new System.Windows.Forms.Button();
            this.btempty = new System.Windows.Forms.Button();
            this.btbusy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBDau = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtStatusPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lbDCP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datP
            // 
            this.datP.AutoScroll = true;
            this.datP.Location = new System.Drawing.Point(52, 140);
            this.datP.Name = "datP";
            this.datP.Size = new System.Drawing.Size(565, 512);
            this.datP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại Phòng";
            // 
            // cbSN
            // 
            this.cbSN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSN.FormattingEnabled = true;
            this.cbSN.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbSN.Location = new System.Drawing.Point(158, 38);
            this.cbSN.Name = "cbSN";
            this.cbSN.Size = new System.Drawing.Size(135, 25);
            this.cbSN.TabIndex = 3;
            this.cbSN.Text = "--Chọn số người--";
            // 
            // cbLP
            // 
            this.cbLP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLP.FormattingEnabled = true;
            this.cbLP.Location = new System.Drawing.Point(158, 76);
            this.cbLP.Name = "cbLP";
            this.cbLP.Size = new System.Drawing.Size(135, 25);
            this.cbLP.TabIndex = 4;
            this.cbLP.Text = "--Chọn loại phòng--";
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(343, 35);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(66, 28);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btKD
            // 
            this.btKD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKD.Location = new System.Drawing.Point(343, 76);
            this.btKD.Name = "btKD";
            this.btKD.Size = new System.Drawing.Size(66, 29);
            this.btKD.TabIndex = 6;
            this.btKD.Text = "Reset";
            this.btKD.UseVisualStyleBackColor = true;
            this.btKD.Click += new System.EventHandler(this.btKD_Click);
            // 
            // dgvDV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.tenDichVu,
            this.soLuong,
            this.donGia,
            this.Tongtien});
            this.dgvDV.Location = new System.Drawing.Point(775, 251);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(507, 458);
            this.dgvDV.TabIndex = 7;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.MinimumWidth = 6;
            this.maDV.Name = "maDV";
            this.maDV.Width = 125;
            // 
            // tenDichVu
            // 
            this.tenDichVu.DataPropertyName = "tenDichVu";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenDichVu.HeaderText = "Dịch Vụ";
            this.tenDichVu.MinimumWidth = 6;
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.DefaultCellStyle = dataGridViewCellStyle4;
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.Width = 125;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tongtien.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tongtien.HeaderText = "Thành Tiền ";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Width = 110;
            // 
            // btnThanhtoanQL
            // 
            this.btnThanhtoanQL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoanQL.Location = new System.Drawing.Point(284, 698);
            this.btnThanhtoanQL.Name = "btnThanhtoanQL";
            this.btnThanhtoanQL.Size = new System.Drawing.Size(99, 40);
            this.btnThanhtoanQL.TabIndex = 8;
            this.btnThanhtoanQL.Text = "Thanh Toán ";
            this.btnThanhtoanQL.UseVisualStyleBackColor = true;
            this.btnThanhtoanQL.Click += new System.EventHandler(this.btnThanhtoanQL_Click);
            // 
            // btDP
            // 
            this.btDP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDP.Location = new System.Drawing.Point(150, 698);
            this.btDP.Name = "btDP";
            this.btDP.Size = new System.Drawing.Size(100, 40);
            this.btDP.TabIndex = 9;
            this.btDP.Text = "Đặt Phòng";
            this.btDP.UseVisualStyleBackColor = true;
            this.btDP.Click += new System.EventHandler(this.btDP_Click);
            // 
            // btempty
            // 
            this.btempty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btempty.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btempty.Location = new System.Drawing.Point(475, 20);
            this.btempty.Name = "btempty";
            this.btempty.Size = new System.Drawing.Size(142, 40);
            this.btempty.TabIndex = 10;
            this.btempty.Text = "Phòng trống";
            this.btempty.UseVisualStyleBackColor = false;
            this.btempty.Click += new System.EventHandler(this.btempty_Click);
            // 
            // btbusy
            // 
            this.btbusy.BackColor = System.Drawing.Color.HotPink;
            this.btbusy.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbusy.Location = new System.Drawing.Point(475, 72);
            this.btbusy.Name = "btbusy";
            this.btbusy.Size = new System.Drawing.Size(142, 40);
            this.btbusy.TabIndex = 11;
            this.btbusy.Text = "Phòng đang sử dụng ";
            this.btbusy.UseVisualStyleBackColor = false;
            this.btbusy.Click += new System.EventHandler(this.btbusy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(979, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "DỊCH VỤ ";
            // 
            // lbBDau
            // 
            this.lbBDau.AutoSize = true;
            this.lbBDau.Location = new System.Drawing.Point(1023, 272);
            this.lbBDau.Name = "lbBDau";
            this.lbBDau.Size = new System.Drawing.Size(0, 16);
            this.lbBDau.TabIndex = 15;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(421, 698);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 40);
            this.btThoat.TabIndex = 19;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtStatusPhong
            // 
            this.txtStatusPhong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStatusPhong.Location = new System.Drawing.Point(785, 213);
            this.txtStatusPhong.Name = "txtStatusPhong";
            this.txtStatusPhong.Size = new System.Drawing.Size(36, 22);
            this.txtStatusPhong.TabIndex = 26;
            this.txtStatusPhong.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên dịch vụ:";
            // 
            // cbDv
            // 
            this.cbDv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDv.FormattingEnabled = true;
            this.cbDv.Location = new System.Drawing.Point(881, 72);
            this.cbDv.Name = "cbDv";
            this.cbDv.Size = new System.Drawing.Size(120, 25);
            this.cbDv.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1029, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1119, 72);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(115, 22);
            this.txtSoluong.TabIndex = 29;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.Location = new System.Drawing.Point(894, 122);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(66, 32);
            this.btnThemDV.TabIndex = 30;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.Location = new System.Drawing.Point(985, 122);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(66, 32);
            this.btnSuaDV.TabIndex = 30;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.Location = new System.Drawing.Point(1078, 122);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(66, 32);
            this.btnXoaDV.TabIndex = 30;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(821, 213);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(0, 16);
            this.lblHoaDon.TabIndex = 31;
            // 
            // lbDCP
            // 
            this.lbDCP.AutoSize = true;
            this.lbDCP.ForeColor = System.Drawing.Color.Black;
            this.lbDCP.Location = new System.Drawing.Point(95, 20);
            this.lbDCP.Name = "lbDCP";
            this.lbDCP.Size = new System.Drawing.Size(0, 16);
            this.lbDCP.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = global::KaraokeNeeNee.Properties.Resources.pngtree_delicate_textured_background_pastel_pink_wall_paint_image_13647899;
            this.panel2.Controls.Add(this.lbDCP);
            this.panel2.Location = new System.Drawing.Point(1077, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 49);
            this.panel2.TabIndex = 25;
            // 
            // QL_Đặt_Phòng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KaraokeNeeNee.Properties.Resources.pngtree_delicate_textured_background_pastel_pink_wall_paint_image_13647899;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 794);
            this.ControlBox = false;
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.cbDv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatusPhong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lbBDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbusy);
            this.Controls.Add(this.btempty);
            this.Controls.Add(this.btDP);
            this.Controls.Add(this.btnThanhtoanQL);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.btKD);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.cbLP);
            this.Controls.Add(this.cbSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datP);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "QL_Đặt_Phòng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Đặt_Phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QL_Đặt_Phòng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel datP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSN;
        private System.Windows.Forms.ComboBox cbLP;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btKD;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnThanhtoanQL;
        private System.Windows.Forms.Button btDP;
        private System.Windows.Forms.Button btempty;
        private System.Windows.Forms.Button btbusy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBDau;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtStatusPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lbDCP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}