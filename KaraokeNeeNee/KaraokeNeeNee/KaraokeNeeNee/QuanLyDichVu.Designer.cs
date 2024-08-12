namespace KaraokeNeeNee
{
    partial class QuanLyDichVu
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
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.btCN = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKD = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTKim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(61, 231);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(1253, 474);
            this.dgvDV.TabIndex = 21;
            this.dgvDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellContentClick);
            // 
            // txtDV
            // 
            this.txtDV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDV.Location = new System.Drawing.Point(300, 121);
            this.txtDV.Multiline = true;
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(483, 32);
            this.txtDV.TabIndex = 8;
            // 
            // btCN
            // 
            this.btCN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCN.Location = new System.Drawing.Point(910, 153);
            this.btCN.Name = "btCN";
            this.btCN.Size = new System.Drawing.Size(93, 36);
            this.btCN.TabIndex = 18;
            this.btCN.Text = "Cập Nhật";
            this.btCN.UseVisualStyleBackColor = true;
            this.btCN.Click += new System.EventHandler(this.btCN_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(1156, 153);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(95, 36);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btKD
            // 
            this.btKD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKD.Location = new System.Drawing.Point(1032, 153);
            this.btKD.Name = "btKD";
            this.btKD.Size = new System.Drawing.Size(102, 36);
            this.btKD.TabIndex = 16;
            this.btKD.Text = "Reset";
            this.btKD.UseVisualStyleBackColor = true;
            this.btKD.Click += new System.EventHandler(this.btKD_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(1156, 93);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(95, 38);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(1032, 91);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(102, 40);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTKim
            // 
            this.btTKim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTKim.Location = new System.Drawing.Point(910, 91);
            this.btTKim.Name = "btTKim";
            this.btTKim.Size = new System.Drawing.Size(93, 40);
            this.btTKim.TabIndex = 13;
            this.btTKim.Text = "Tìm Kiếm ";
            this.btTKim.UseVisualStyleBackColor = true;
            this.btTKim.Click += new System.EventHandler(this.btTKim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Dịch Vụ Cần Tìm:";
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KaraokeNeeNee.Properties.Resources.pngtree_delicate_textured_background_pastel_pink_wall_paint_image_136478991;
            this.ClientSize = new System.Drawing.Size(1389, 787);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCN);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKD);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTKim);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDichVu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Button btCN;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKD;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTKim;
        private System.Windows.Forms.Label label2;
    }
}