namespace KaraokeNeeNee
{
    partial class CapNhatDV
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaDV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "CẬP NHẬT DỊCH VỤ";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(263, 286);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 35);
            this.btHuy.TabIndex = 47;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(89, 286);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(88, 35);
            this.btSave.TabIndex = 46;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(169, 216);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(221, 22);
            this.txtSL.TabIndex = 45;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(141, 167);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(249, 22);
            this.txtGia.TabIndex = 44;
            // 
            // txtTDV
            // 
            this.txtTDV.Location = new System.Drawing.Point(141, 122);
            this.txtTDV.Name = "txtTDV";
            this.txtTDV.Size = new System.Drawing.Size(249, 22);
            this.txtTDV.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Số Lượng Dịch Vụ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên Dịch Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã Dịch Vụ:";
            // 
            // txtmaDV
            // 
            this.txtmaDV.Enabled = false;
            this.txtmaDV.Location = new System.Drawing.Point(141, 77);
            this.txtmaDV.Name = "txtmaDV";
            this.txtmaDV.Size = new System.Drawing.Size(249, 22);
            this.txtmaDV.TabIndex = 49;
            this.txtmaDV.Click += new System.EventHandler(this.txtmaDV_Click);
            // 
            // CapNhatDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 367);
            this.ControlBox = false;
            this.Controls.Add(this.txtmaDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTDV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CapNhatDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatDV";
            this.Load += new System.EventHandler(this.CapNhatDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSL;
        public System.Windows.Forms.TextBox txtGia;
        public System.Windows.Forms.TextBox txtTDV;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtmaDV;
    }
}