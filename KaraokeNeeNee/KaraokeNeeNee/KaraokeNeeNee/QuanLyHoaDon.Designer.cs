namespace KaraokeNeeNee
{
    partial class QuanLyHoaDon
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
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLHD = new System.Windows.Forms.DateTimePicker();
            this.btTKim = new System.Windows.Forms.Button();
            this.btKD = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(152, 255);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(1170, 481);
            this.dgvHD.TabIndex = 4;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellContentClick);
            // 
            // txtmaHD
            // 
            this.txtmaHD.Location = new System.Drawing.Point(354, 117);
            this.txtmaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaHD.Multiline = true;
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(520, 40);
            this.txtmaHD.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Hoá Đơn Cần Tìm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày Lập:";
            // 
            // dateLHD
            // 
            this.dateLHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLHD.Location = new System.Drawing.Point(255, 183);
            this.dateLHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateLHD.Name = "dateLHD";
            this.dateLHD.Size = new System.Drawing.Size(156, 27);
            this.dateLHD.TabIndex = 22;
            this.dateLHD.ValueChanged += new System.EventHandler(this.dateLHD_ValueChanged);
            // 
            // btTKim
            // 
            this.btTKim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTKim.Location = new System.Drawing.Point(1051, 113);
            this.btTKim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTKim.Name = "btTKim";
            this.btTKim.Size = new System.Drawing.Size(123, 44);
            this.btTKim.TabIndex = 23;
            this.btTKim.Text = "Tìm Kiếm ";
            this.btTKim.UseVisualStyleBackColor = true;
            this.btTKim.Click += new System.EventHandler(this.btTKim_Click);
            // 
            // btKD
            // 
            this.btKD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKD.Location = new System.Drawing.Point(1051, 172);
            this.btKD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btKD.Name = "btKD";
            this.btKD.Size = new System.Drawing.Size(123, 39);
            this.btKD.TabIndex = 24;
            this.btKD.Text = "Reset";
            this.btKD.UseVisualStyleBackColor = true;
            this.btKD.Click += new System.EventHandler(this.btKD_Click);
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.Location = new System.Drawing.Point(1192, 113);
            this.btXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(130, 44);
            this.btXem.TabIndex = 25;
            this.btXem.Text = "Xem Chi Tiết";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(1192, 174);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(130, 39);
            this.btThoat.TabIndex = 26;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KaraokeNeeNee.Properties.Resources.pngtree_delicate_textured_background_pastel_pink_wall_paint_image_13647899;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.btKD);
            this.Controls.Add(this.btTKim);
            this.Controls.Add(this.dateLHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaHD);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateLHD;
        private System.Windows.Forms.Button btTKim;
        private System.Windows.Forms.Button btKD;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Button btThoat;
    }
}