using KaraokeNeeNee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace KaraokeNeeNee
{
    public partial class Thanhtoan : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLKaraoke"].ConnectionString;
        public Thanhtoan()
        {
            InitializeComponent();
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            var maHD = QL_Đặt_Phòng.MaHD();
            lblHoaDon.Text = maHD.ToString();
            var hoadon = GetHoadon(maHD);
            lblGionhanphong.Text = DateTime.Parse(hoadon.gioNhanPhong.ToString()).ToString("dd/MM/yyyy HH:mm");
            lblGiotraphong.Text = DateTime.Parse(hoadon.gioTraPhong.ToString()).ToString("dd/MM/yyyy HH:mm");
            lblMaP.Text = hoadon.maP.ToString();
            lblTienDV.Text = hoadon.tongtienDV.ToString();
            lblGiaphong.Text = hoadon.giaTien.ToString();
            TimeSpan duration = DateTime.Parse(hoadon.gioTraPhong.ToString()) - DateTime.Parse(hoadon.gioNhanPhong.ToString());
            double hours = Math.Round(duration.TotalHours, 2);
            lblTongGT.Text = hours.ToString() + " giờ";
            decimal totalPriceP = Math.Round((decimal)hours * (decimal)hoadon.giaTien, 0);
            decimal totalPriceAll = Math.Round(hoadon.tongtienDV + totalPriceP, 0);
            decimal totalVAT = (decimal)totalPriceAll * (decimal)0.05;
            decimal totalPriceTT = Math.Round((decimal)totalPriceAll + (decimal)totalVAT, 0);
            lblTongTienP.Text = totalPriceP.ToString();
            lblTongtienTT.Text = totalPriceTT.ToString();
            loadDV(maHD);
            lblTienthua.Text = "0";
        }
        private Hoadon GetHoadon(string maHD)
        {
            var hoaDon = new Hoadon();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_GetHoaDonByMaHD";
                    cmd.Parameters.AddWithValue("@maHD", maHD.Trim());
                    cnn.Open();
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        hoaDon.maHD = dta["maHD"].ToString();
                        hoaDon.maP = dta["maP"].ToString();
                        hoaDon.gioNhanPhong = DateTime.Parse(dta["gioNhanPhong"].ToString());
                        hoaDon.gioTraPhong = DateTime.Parse(dta["gioTraPhong"].ToString());
                        hoaDon.thue = float.Parse(dta["thue"].ToString());
                        hoaDon.maLP = dta["maLP"].ToString();
                        hoaDon.giaTien = decimal.Parse(dta["giaTien"].ToString());
                        var tongtienDV = dta["tongtienDV"].ToString();
                        if (!string.IsNullOrEmpty(tongtienDV))
                        {
                            hoaDon.tongtienDV = decimal.Parse(dta["tongtienDV"].ToString());
                        }
                        else
                        {
                            hoaDon.tongtienDV = 0;
                        }
                    }
                    cnn.Close();

                }
            }
            return hoaDon;
        }
        private void loadDV(string maHD)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_GetChitietdichvu";
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvCTDV.DataSource = tb;
                    }
                }
            }
        }

        private void txtTiennhan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTiennhan.Text))
            {
                decimal tiennhan = decimal.Parse(txtTiennhan.Text);
                decimal totalTienTT = decimal.Parse(lblTongtienTT.Text);
                decimal totalTienThua = (tiennhan - totalTienTT);
                if (totalTienThua > 0)
                {
                    lblTienthua.Text = totalTienThua.ToString();
                }
                else
                {
                    lblTienthua.Text = "0";
                }
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            var maHD = lblHoaDon.Text;
            var maP = lblMaP.Text;
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn để thanh toán");
                return;
            }
            float tiennhan = float.Parse(txtTiennhan.Text);
            float totalPriceTT = float.Parse(lblTongtienTT.Text);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_Thanhtoan";
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maP", maP);
                    cmd.Parameters.AddWithValue("@tiennhan", tiennhan);
                    cmd.Parameters.AddWithValue("@tongtien", totalPriceTT);

                    cnn.Open();
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thanh toán hóa đơn " + maHD + " thành công");
                    }
                    cnn.Close();
                    this.Hide();
                    QL_Đặt_Phòng qldp = new QL_Đặt_Phòng();
                    qldp.RefreshForm();
                    qldp.Show();
                }
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            QL_Đặt_Phòng qldp = new QL_Đặt_Phòng();
            qldp.Show();
        }
    }
}
