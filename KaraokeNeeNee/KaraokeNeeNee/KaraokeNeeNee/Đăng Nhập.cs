using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KaraokeNeeNee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string tk;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            try
            {
                con.Open();
                string sdt = txtSDT.Text.Trim();
                string mk = txtMK.Text.Trim();

                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("VUI LÒNG NHẬP SỐ ĐIỆN THOẠI TÀI KHOẢN");
                    txtSDT.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("VUI LÒNG NHẬP MẬT KHẨU TÀI KHOẢN");
                    txtMK.Focus();
                    return;
                }

                string sql = "SELECT * FROM NhanVien WHERE soDienThoai = @sdt AND password = @mk";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@mk", mk);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read())
                {
                    tk = dta["maNV"].ToString();
                    string maLoaiNV = dta["maLNV"].ToString();
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                    FormChinh f1 = new FormChinh();
                    this.Hide();
                    f1.Show();
                    if (maLoaiNV == "LNV002")
                    {
                        f1.EnableQuanLyMenuItem(false);
                        f1.EnableThongKe(false);
                    }
                }
                else
                {
                    MessageBox.Show("SAI SỐ ĐIỆN THOẠI HOẶC SAI MẬT KHẨU");
                    txtMK.Clear();
                    txtSDT.Clear();
                    txtSDT.Focus();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI KẾT NỐI: " + ex.Message);
            }          
        }
        static public String Tentk()
        {
            return tk;
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtMK.Focus();
            }
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Kiểm tra nếu các ô có được nhập đầy đủ hay không
                if (txtSDT.Text.Trim() == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP SỐ ĐIỆN THOẠI TÀI KHOẢN");
                    txtMK.Clear();
                    txtSDT.Clear();
                    txtSDT.Focus();
                }
                else if (txtMK.Text.Trim() == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MẬT KHẨU TÀI KHOẢN");
                    txtMK.Focus();
                }
                else
                {
                    // Gọi sự kiện Click của buttonDN để xử lý đăng nhập
                    buttonDN.PerformClick();
                }
            }
        }

    }
}

