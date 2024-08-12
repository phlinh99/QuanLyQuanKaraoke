using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace KaraokeNeeNee
{
    public partial class Form1 : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLKaraoke"].ConnectionString;
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
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string sdt = txtSDT.Text;
                string mk = txtMK.Text;
                string sql = "select * from NhanVien where soDienThoai = '" + sdt + "'  and password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (sdt.Trim() == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP SỐ ĐIỆN THOẠI TÀI KHOẢN ");

                }
                else if (mk.Trim() == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MẬT KHẨU TÀI KHOẢN ");

                }
                else if (dta.Read() == true)
                {
                    tk = dta["maNV"].ToString();
                    string maLoaiNV = dta["maLNV"].ToString();
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                    if (maLoaiNV == "LNV001")
                    {
                        FormChinh f1 = new FormChinh();
                        this.Hide();
                        f1.Show();
                    }
                    else if (maLoaiNV == "LNV002")
                    {
                        FormChinh f1 = new FormChinh();
                        this.Hide();
                        f1.Show();
                        f1.EnableQuanLyMenuItem(false);
                        f1.EnableThongKe(false);
                    }                  
                }
                else
                {
                    MessageBox.Show("SAI SỐ ĐIỆN THOẠI HOẶC SAI MẬT KHẨU");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI KẾT NỐI");
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
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void buttonDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

    }
}

