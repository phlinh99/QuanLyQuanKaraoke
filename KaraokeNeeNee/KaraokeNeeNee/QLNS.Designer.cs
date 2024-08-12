namespace KaraokeNeeNee
{
    partial class QLNS
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTKim = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btKD = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btCN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 218);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1041, 542);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(138, 100);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(269, 22);
            this.txtmaNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Tên";
            // 
            // btTKim
            // 
            this.btTKim.Location = new System.Drawing.Point(607, 83);
            this.btTKim.Name = "btTKim";
            this.btTKim.Size = new System.Drawing.Size(85, 37);
            this.btTKim.TabIndex = 6;
            this.btTKim.Text = "Tìm Kiếm ";
            this.btTKim.UseVisualStyleBackColor = true;
            this.btTKim.Click += new System.EventHandler(this.btTKim_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(723, 83);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(82, 37);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(846, 85);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 35);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btKD
            // 
            this.btKD.Location = new System.Drawing.Point(730, 149);
            this.btKD.Name = "btKD";
            this.btKD.Size = new System.Drawing.Size(75, 33);
            this.btKD.TabIndex = 9;
            this.btKD.Text = "Reset";
            this.btKD.UseVisualStyleBackColor = true;
            this.btKD.Click += new System.EventHandler(this.btKD_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(846, 149);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 33);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(138, 149);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(269, 22);
            this.txtTen.TabIndex = 11;
            // 
            // btCN
            // 
            this.btCN.Location = new System.Drawing.Point(607, 149);
            this.btCN.Name = "btCN";
            this.btCN.Size = new System.Drawing.Size(82, 33);
            this.btCN.TabIndex = 12;
            this.btCN.Text = "Cập Nhật";
            this.btCN.UseVisualStyleBackColor = true;
            this.btCN.Click += new System.EventHandler(this.btCN_Click);
            // 
            // QLNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 772);
            this.Controls.Add(this.btCN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKD);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTKim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLNS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNS";
            this.Load += new System.EventHandler(this.QLNS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTKim;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btKD;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btCN;
    }
}