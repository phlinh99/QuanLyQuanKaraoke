using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeNeeNee
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        Form formCon1;
        Form formCon2;
        Form formCon3;
        Form formCon4;
        Form formCon5;
        Form formCon6;
       
        private void ShowChildForm(Form childForm)
        {
            // Đóng form con cũ nếu nó đã được mở
            if (formCon1 != null && !formCon1.IsDisposed)
            {
                formCon1.Close();
            }

            if (formCon2 != null && !formCon2.IsDisposed)
            {
                formCon2.Close();
            }
            if (formCon3 != null && !formCon3.IsDisposed)
            {
                formCon3.Close();
            }

            if (formCon4 != null && !formCon4.IsDisposed)
            {
                formCon4.Close();
            }
            if (formCon5 != null && !formCon5.IsDisposed)
            {
                formCon5.Close();
            }

            if (formCon6 != null && !formCon6.IsDisposed)
            {
                formCon6.Close();
            }
              
            // Hiển thị form con mới
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();

            // Lưu form con mới vào biến tương ứng
            if (childForm is QL_Đặt_Phòng)
            {
                formCon1 = childForm;
            }
            else if (childForm is QLTK)
            {
                formCon2 = childForm;
            }
            else if (childForm is QuanLyDichVu)
            {
                formCon3 = childForm;
            }
            else if (childForm is QuanLyHoaDon)
            {
                formCon4 = childForm;
            }
            else if (childForm is QuanLyThietBi)
            {
                formCon5 = childForm;
            }
            else if (childForm is QLNS)
            {
                formCon6 = childForm;
            }

        }


        private void đĂNGXUẤTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN ĐĂNG XUẤT HAY KHÔNG ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:

                    Application.Exit();
                    break;

                case DialogResult.No:

                    break;
            }
        }

        private void đẶTPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Đặt_Phòng f = new QL_Đặt_Phòng();
            ShowChildForm(f);

        }

        private void tHỐNGKẾToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTK f = new QLTK();           
            ShowChildForm(f);

        }

        private void qUẢNLÝNHÂNSỰToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLNS f = new QLNS();          
            ShowChildForm(f);
        }

       
        private void qUẢNLÝDỊCHVỤToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyDichVu f = new QuanLyDichVu();         
            ShowChildForm(f);
        }

        private void qUẢNLÝHÓAĐƠNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyHoaDon f = new QuanLyHoaDon();            
            ShowChildForm(f);
        }

        private void qUẢNLÝTHIẾTBỊToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyThietBi f = new QuanLyThietBi();          
            ShowChildForm(f);
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
        public void EnableQuanLyMenuItem(bool enable)
        {
            qUẢNLÝToolStripMenuItem.Enabled = enable;
        }
        public void EnableThongKe(bool enable)
        {
            tHỐNGKẾToolStripMenuItem.Enabled = enable;
        }
    }
}
