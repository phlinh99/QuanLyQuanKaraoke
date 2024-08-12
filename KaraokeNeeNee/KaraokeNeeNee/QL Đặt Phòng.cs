using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Configuration;
//using System.Security.Cryptography;
using KaraokeNeeNee.DTO;

namespace KaraokeNeeNee
{
    public partial class QL_Đặt_Phòng : Form
    {
        double tot;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        private Button bt;
        private Label des;
        private Label soN;
        //string constr = ConfigurationManager.ConnectionStrings["QLKaraoke"].ConnectionString;
        public QL_Đặt_Phòng()
        {
            InitializeComponent();
            //cn = new SqlConnection();
            //cn.ConnectionString = constr;
        }

        private void QL_Đặt_Phòng_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd = new SqlCommand("select * from LoaiPhong", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbLP.DataSource = dt;
            cbLP.DisplayMember = "tenLoaiPhong";
            cbLP.ValueMember = "maLP";
            cbLP.Text = "--Chọn loại phòng--";
            GetData();
            load_cbDv();
            if (!string.IsNullOrEmpty(lblHoaDon.Text.ToString()))
            {
                loadDv();
            }
        }
        public void setDefault()
        {
            cbSN.Text = "--Chọn số người--";
            cbLP.Text = "--Chọn loại phòng--";
        }
        private void GetData()
        {
            datP.Controls.Clear();
            setDefault();
            cn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select p.maP, p.soNguoi, lp.tenLoaiPhong,\r\n  case when p.tinhTrangPhong = 0 then N'Phòng trống'\r\n  when p.tinhTrangPhong = 1 then N'Phòng bận'\r\n  ELSE N'Phòng trống' end as tenTrangThaiPhong\r\n  from Phong p\r\n  INNER JOIN LoaiPhong lp ON lp.maLP = p.maLP", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                

                des = new Label();
                des.Text = dr["tenLoaiPhong"].ToString();
                des.Width = 50;
                des.BackColor = Color.White;
                des.TextAlign = ContentAlignment.MiddleLeft;
                des.Dock = DockStyle.Bottom;

                soN = new Label();
                soN.Text = dr["soNguoi"].ToString();
                soN.Width = 20;
                // soN.BackColor = Color.White;
                soN.TextAlign = ContentAlignment.MiddleRight;
                soN.Dock = DockStyle.Right;

                bt = new Button();
                bt.Width = 120;
                bt.Height = 100;
                bt.Text = dr["tenTrangThaiPhong"].ToString() + " - " + dr["maP"].ToString();
                bt.FlatStyle = FlatStyle.Flat;
                bt.BackColor = Color.FromArgb(41, 128, 185);
                bt.ForeColor = Color.Black;
                datP.Controls.Add(bt);
                bt.Click += new System.EventHandler(bt_Click);
                if (bt.Text.Contains("Phòng bận"))
                {
                    bt.BackColor = Color.HotPink;
                }
                else
                {
                    bt.BackColor = Color.FromArgb(41, 128, 185);
                }
                bt.Controls.Add(des);
                des.Controls.Add(soN);
            }
            dr.Close();
            cn.Close();
        }
        private string ExtractRoomCode(string btText)
        {
            string[] parts = btText.Split('-');

            if (parts.Length >= 2)
            {
                return parts[1].Trim();
            }
            else
            {

                return "";
            }
        }
        private void bt_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string btText = clickedButton.Text;
            if (btText.IndexOf("Phòng bận") != -1)
            {
                var arrPhong = btText.Split('-');
                if (arrPhong.Length > 1)
                {
                    var maP = arrPhong[1].Trim();
                    var objHD = GetMaHD(maP);
                    if (objHD == null)
                    {
                        MessageBox.Show("Thông tin hóa đơn phòng " + maP + " không tồn tại");
                        return;
                    }
                    if (objHD != null && string.IsNullOrEmpty(objHD.maHD))
                    {
                        MessageBox.Show("Thông tin hóa đơn phòng " + maP + " không tồn tại");
                        return;
                    }
                    lblHoaDon.Text = "Mã hóa đơn: " + objHD.maHD;
                    cbSN.SelectedValue = objHD.thue;
                    cbLP.SelectedValue = objHD.maLP;
                    loadDv();
                }
                txtStatusPhong.Text = "on";
            }
            else
            {
                dgvDV.Refresh();
                loadDv();
                lblHoaDon.Text = "";
                txtStatusPhong.Text = "";
            }
            string roomCode = "Mã Phòng: " + ExtractRoomCode(btText);

            lbDCP.Text = roomCode;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            datP.Controls.Clear();
            cn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select p.maP, p.soNguoi, lp.tenLoaiPhong,  case when p.tinhTrangPhong = 0 then N'Phòng trống'  when p.tinhTrangPhong = 1 then N'Phòng bận' ELSE N'Phòng trống' end as tenTrangThaiPhong from Phong p INNER JOIN LoaiPhong lp ON lp.maLP = p.maLP where tenLoaiPhong = @tenLoaiPhong and soNguoi = @soNguoi", cn);
            cmd.Parameters.AddWithValue("@tenLoaiPhong", cbLP.Text);
            cmd.Parameters.AddWithValue("@soNguoi", cbSN.Text);

           
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                des = new Label();
                des.Text = dr["tenLoaiPhong"].ToString();
                des.Width = 50;
                des.BackColor = Color.White;
                des.TextAlign = ContentAlignment.MiddleLeft;
                des.Dock = DockStyle.Bottom;

                soN = new Label();
                soN.Text = dr["soNguoi"].ToString();
                soN.Width = 20;
                // soN.BackColor = Color.White;
                soN.TextAlign = ContentAlignment.MiddleRight;
                soN.Dock = DockStyle.Right;

                bt = new Button();
                bt.Width = 120;
                bt.Height = 100;
                bt.Text = dr["tenTrangThaiPhong"].ToString() + " - " + dr["maP"].ToString();
                bt.FlatStyle = FlatStyle.Flat;
                bt.BackColor = Color.FromArgb(41, 128, 185);
                bt.ForeColor = Color.Black;
                datP.Controls.Add(bt);
                bt.Click += new System.EventHandler(bt_Click);
                if (bt.Text.Contains("Phòng bận"))
                {
                    bt.BackColor = Color.HotPink;
                }
                else
                {
                    bt.BackColor = Color.FromArgb(41, 128, 185);
                }
                bt.Controls.Add(des);
                des.Controls.Add(soN);
            }
            dr.Close();
            cn.Close();

        }

        private void btKD_Click(object sender, EventArgs e)
        {

            cbLP.ResetText();
            cbSN.ResetText();
            GetData();
        }

        private void btempty_Click(object sender, EventArgs e)
        {
            datP.Controls.Clear();
            cn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select p.maP, p.soNguoi, lp.tenLoaiPhong,  case when p.tinhTrangPhong = 0 then N'Phòng trống'  when p.tinhTrangPhong = 1 then N'Phòng bận' ELSE N'Phòng trống' end as tenTrangThaiPhong from Phong p INNER JOIN LoaiPhong lp ON lp.maLP = p.maLP where p.tinhTrangPhong = 0", cn);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                des = new Label();
                des.Text = dr["tenLoaiPhong"].ToString();
                des.Width = 50;
                des.BackColor = Color.White;
                des.TextAlign = ContentAlignment.MiddleLeft;
                des.Dock = DockStyle.Bottom;

                soN = new Label();
                soN.Text = dr["soNguoi"].ToString();
                soN.Width = 20;
                // soN.BackColor = Color.White;
                soN.TextAlign = ContentAlignment.MiddleRight;
                soN.Dock = DockStyle.Right;

                bt = new Button();
                bt.Width = 120;
                bt.Height = 100;
                bt.Text = dr["tenTrangThaiPhong"].ToString() + " - " + dr["maP"].ToString();
                bt.FlatStyle = FlatStyle.Flat;
                bt.BackColor = Color.FromArgb(41, 128, 185);
                bt.ForeColor = Color.Black;
                datP.Controls.Add(bt);
                bt.Click += new System.EventHandler(bt_Click);
                if (bt.Text.Contains("Phòng bận"))
                {
                    bt.BackColor = Color.HotPink;
                }
                else
                {
                    bt.BackColor = Color.FromArgb(41, 128, 185);
                }
                bt.Controls.Add(des);
                des.Controls.Add(soN);
            }
            dr.Close();
            cn.Close();

        }

        private void btbusy_Click(object sender, EventArgs e)
        {
            datP.Controls.Clear();
            cn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select p.maP, p.soNguoi, lp.tenLoaiPhong,  case when p.tinhTrangPhong = 0 then N'Phòng trống'  when p.tinhTrangPhong = 1 then N'Phòng bận' ELSE N'Phòng trống' end as tenTrangThaiPhong from Phong p INNER JOIN LoaiPhong lp ON lp.maLP = p.maLP where p.tinhTrangPhong = 1", cn);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                des = new Label();
                des.Text = dr["tenLoaiPhong"].ToString();
                des.Width = 50;
                des.BackColor = Color.White;
                des.TextAlign = ContentAlignment.MiddleLeft;
                des.Dock = DockStyle.Bottom;

                soN = new Label();
                soN.Text = dr["soNguoi"].ToString();
                soN.Width = 20;
                // soN.BackColor = Color.White;
                soN.TextAlign = ContentAlignment.MiddleRight;
                soN.Dock = DockStyle.Right;

                bt = new Button();
                bt.Width = 120;
                bt.Height = 100;
                bt.Text = dr["tenTrangThaiPhong"].ToString() + " - " + dr["maP"].ToString();
                bt.FlatStyle = FlatStyle.Flat;
                bt.BackColor = Color.FromArgb(41, 128, 185);
                bt.ForeColor = Color.Black;
                datP.Controls.Add(bt);
                bt.Click += new System.EventHandler(bt_Click);
                if (bt.Text.Contains("Phòng bận"))
                {
                    bt.BackColor = Color.HotPink;
                }
                else
                {
                    bt.BackColor = Color.FromArgb(41, 128, 185);
                }
                bt.Controls.Add(des);
                des.Controls.Add(soN);
            }
            dr.Close();
            cn.Close();

        }

        private void load_cbDv()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM DichVu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        cbDv.DataSource = tb;
                        cbDv.DisplayMember = "tenDichVu";
                        cbDv.ValueMember = "maDV";
                        cbDv.Text = "--Chọn dịch vụ--";
                    }
                }
            }
        }
       
        private void btThoat_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            con.Open();
            string sql = "select * from NhanVien ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                string maLoaiNV = dta["maLNV"].ToString();
                if (maLoaiNV == "LNV001")
                {
                    this.Close();
                }
                else if (maLoaiNV == "LNV002")
                {
                    Application.Exit();
                }
            }
        }

        private void btDP_Click(object sender, EventArgs e)
        {
            if (txtStatusPhong.Text == "on")
            {
                MessageBox.Show("Phòng đã có khách sử dụng");
                return;
            }
            if (string.IsNullOrEmpty(lbDCP.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng hát");
                return;
            }
            if (string.IsNullOrEmpty(cbLP.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng chọn loại phòng");
                return;
            }
            string mhdOld = GetMahdDESC();
            if (mhdOld == null)
            {
                mhdOld = "HDAA000";
            }
            var arrlbDCP = lbDCP.Text.Split(':');
            if (arrlbDCP.Length <= 1)
            {
                MessageBox.Show("Không tìm thấy mã phòng");
                return;
            }
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            string maP = arrlbDCP[1].ToString();
            var maNV = Form1.Tentk();
            var subStringMahd = mhdOld.Substring(mhdOld.Length - 3);
            var IdEntity = int.Parse(subStringMahd) + 1;
            string formattedNumber = IdEntity.ToString("D3");
            string maHD = string.Format("{0}{1}", "HDAA", formattedNumber);
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertHoaDon";
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaP", maP.Trim());
                    cmd.Parameters.AddWithValue("@gioNhanPhong", startDate);
                    cmd.Parameters.AddWithValue("@gioTraPhong", endDate);
                    cmd.Parameters.AddWithValue("@thue", "5");
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@maLP", cbLP.SelectedValue);
                    cnn.Open();
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Đã thêm hóa đơn " + maHD + " thành công!", "Thông báo");
                    }
                    cnn.Close();
                }
            }
            lblHoaDon.Text = "Mã hóa đơn: " + maHD;
            datP.Controls.Clear();
            cbDv.Text = "--Chọn dịch vụ--";
            cbLP.Text = "--Chọn loại phòng--";
            GetData();
            dgvDV.Refresh();
        }
        public string GetMahdDESC()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM HoaDon ORDER BY maHD DESC", cnn))
                {
                    cnn.Open();
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        return dta["maHD"].ToString();
                    }
                    cnn.Close();
                }
            }
            return null;
        }
        public decimal GetPriceDV()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM DichVu where maDV = '" + cbDv.SelectedValue + "'", cnn))
                {
                    cnn.Open();
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        var prices = dta["donGia"].ToString();
                        if (prices != null)
                        {
                            return decimal.Parse(prices);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    cnn.Close();
                }
            }
            return 0;
        }
        public Hoadon GetMaHD(string maP)
        {
            var hoaDon = new Hoadon();
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where maP = '" + maP.Trim() + "' AND trangthai = 0", cnn))
                {
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
                    }
                    cnn.Close();

                }
            }
            return hoaDon;
        }
        private int kiemtraMaDV(string maHD)
        {
            string sql = "SELECT * FROM ChiTietDichVu WHERE maDV = N'" + cbDv.SelectedValue + "' AND maHD = N'" + maHD.Trim() + "'";
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        if (tb.Rows.Count > 0) return 1;
                        else return 0;
                    }
                }
            }
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDv.Text.ToString()))
            {
                MessageBox.Show("Vui chọn dịch vụ");
                return;
            }
            if (string.IsNullOrEmpty(txtSoluong.Text.ToString()))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            if (string.IsNullOrEmpty(lblHoaDon.Text.ToString()))
            {
                MessageBox.Show("Vui lòng đặt phòng trước khi đặt dịch vụ");
                return;
            }
            var arrMaHD = lblHoaDon.Text.Split(':');
            if (arrMaHD.Length <= 1)
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn");
                return;
            }
            var maHD = arrMaHD[1].Trim();
            if (kiemtraMaDV(maHD) > 0)
            {
                MessageBox.Show("Mã dịch vụ " + cbDv.Text + " đã tồn tại");
                return;
            }

            int ckSoLuongDV = ckSoLuongDichVu();
            if(ckSoLuongDV == 0)
            {
                MessageBox.Show("Mã dịch vụ " + cbDv.Text + " không đủ số lượng");
                return;
            }
            decimal dongia = GetPriceDV();
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InserChitietdichvu";
                    cmd.Parameters.AddWithValue("@maDV", cbDv.SelectedValue);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@soluong", int.Parse(txtSoluong.Text));
                    cmd.Parameters.AddWithValue("@tongtien", int.Parse(txtSoluong.Text) * decimal.Parse(dongia.ToString()));
                    cnn.Open();
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Đã thêm dịch vụ thành công", "Thông báo");
                    }
                    cnn.Close();
                    loadDv();
                    clearDV();
                }
            }
        }
        public void loadDv()
        {
            var lblHoadon = lblHoaDon.Text.ToString();
            var maHD = string.Empty;
            if (!string.IsNullOrEmpty(lblHoadon))
            {
                var arrMaHD = lblHoadon.Split(':');
                if (arrMaHD.Length > 1)
                {
                    maHD = arrMaHD[1].ToString().Trim();
                }
            }
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
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
                        dgvDV.DataSource = tb;
                    }
                }
            }
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow = e.RowIndex;
                cbDv.SelectedValue = dgvDV.Rows[numrow].Cells[0].Value.ToString();
                txtSoluong.Text = dgvDV.Rows[numrow].Cells[3].Value.ToString();
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            var lblHoadon = lblHoaDon.Text.ToString();
            var maHD = string.Empty;
            if (!string.IsNullOrEmpty(lblHoadon))
            {
                var arrMaHD = lblHoadon.Split(':');
                if (arrMaHD.Length > 1)
                {
                    maHD = arrMaHD[1].ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            var maDV = cbDv.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maDV))
            {
                MessageBox.Show("Không tìm thấy thông tin dịch vụ");
                return;
            }
            int ckMaDV = kiemtraMaDV(maHD);
            if (ckMaDV == 0)
            {
                MessageBox.Show("Không tìm thấy mã dịch vụ cần cập nhật. Vui lòng không chỉnh sửa mã dịch vụ");
                return;
            }
            int ckSoLuongDV = ckSoLuongDichVu();
            if(ckSoLuongDV == 0)
            {
                MessageBox.Show("Số lượng dịch vụ không đủ");
                return;
            }
            decimal dongia = GetPriceDV();
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_UpdateChitietdichvu";
                    cmd.Parameters.AddWithValue("@maDV", cbDv.SelectedValue);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@soLuong", int.Parse(txtSoluong.Text));
                    cmd.Parameters.AddWithValue("@tongtien", int.Parse(txtSoluong.Text) * decimal.Parse(dongia.ToString()));
                    cnn.Open();
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật dịch vụ thành công", "Thông báo");
                    }
                    cnn.Close();
                    loadDv();
                }
            }
        }
        public void RefreshForm()
        {
            QL_Đặt_Phòng_Load(null, EventArgs.Empty);
        }
        private void clearDV()
        {
            cbDv.Text = "--Chọn dịch vụ--";
            txtSoluong.Text = "0";
        }
        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            var lblHoadon = lblHoaDon.Text.ToString();
            var maHD = string.Empty;
            if (!string.IsNullOrEmpty(lblHoadon))
            {
                var arrMaHD = lblHoadon.Split(':');
                if (arrMaHD.Length > 1)
                {
                    maHD = arrMaHD[1].ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            var maDV = cbDv.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maDV))
            {
                MessageBox.Show("Không tìm thấy thông tin dịch vụ");
                return;
            }
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaChitietDichVu";
                    cmd.Parameters.AddWithValue("@maHD", maHD.Trim());
                    cmd.Parameters.AddWithValue("@maDV", maDV.Trim());
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        txtSoluong.ResetText();
                        cbDv.ResetText();
                        DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            int kq = cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Đã xóa thành công !", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công !", "Thông báo");
                            }

                            cnn.Close();
                        }
                        clearDV();
                        loadDv();
                    }
                }
            }
        }

        private void btnThanhtoanQL_Click(object sender, EventArgs e)
        {
            var lblHoadon = lblHoaDon.Text.ToString();
            var maHD = string.Empty;
            if (!string.IsNullOrEmpty(lblHoadon))
            {
                var arrMaHD = lblHoadon.Split(':');
                if (arrMaHD.Length > 1)
                {
                    maHD = arrMaHD[1].ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
                return;
            }
            maHDPL = maHD;

            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_UpdateGioTraPhong";
                    cmd.Parameters.AddWithValue("@maHD", maHD.Trim());
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            cnn.Close();
                        }
                        else
                        {

                            MessageBox.Show("Không cập nhật được giờ trả phòng", "Thông báo");
                        }
                        clearDV();
                        loadDv();
                    }
                }
            }

            this.Hide();
            Thanhtoan f1 = new Thanhtoan();
            f1.Show();
        }
        static string maHDPL { get; set; }
        public static string MaHD()
        {
            return maHDPL;
        }
        private int ckSoLuongDichVu()
        {
            string maDV = cbDv.SelectedValue.ToString();
            int soLuong = int.Parse(txtSoluong.Text.ToString());
            string sql = "SELECT * FROM DichVu WHERE maDV = '"+maDV+"' AND soLuongDV >= '" +  soLuong +"'";
            using (SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        if (tb.Rows.Count > 0) return 1;
                        else return 0;
                    }
                }
            }
           
        }
    }
}
