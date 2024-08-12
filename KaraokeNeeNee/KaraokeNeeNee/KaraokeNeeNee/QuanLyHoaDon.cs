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
    public partial class QuanLyHoaDon : Form
    {
        SqlConnection con;
        QuanLyHoaDon qlhd;
        public QuanLyHoaDon()
        {
            InitializeComponent();
            qlhd = new QuanLyHoaDon(this);
        }
        public QuanLyHoaDon(QuanLyHoaDon qlHD)
        {
            qlhd = qlHD;
        }
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            load();
            qlhd.GetSizeColumn();
        }
        private void load()
        {
            using (SqlCommand cmd = new SqlCommand("exec hienThiDSHD", con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHD.DataSource = dt;
                }

                dgvHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);

            }
        }
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetSizeColumn()
        {
            qlhd.dgvHD.Columns[0].Width = 100;
            qlhd.dgvHD.Columns[1].Width = 150;
            qlhd.dgvHD.Columns[2].Width = 120;
            qlhd.dgvHD.Columns[3].Width = 120;
            qlhd.dgvHD.Columns[4].Width = 140;
            qlhd.dgvHD.Columns[5].Width = 100;
          
            qlhd.dgvHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void btTKim_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT maHD, ngayLap, tongTien,  tienKhachTra,  hoTen as 'Tên Nhân Viên', trangThai " +
                           "FROM HoaDon " +
                           "INNER JOIN NhanVien ON HoaDon.maNV = NhanVien.maNV " +
                           "WHERE maHD = @maHD";
            using (SqlCommand cmd = new SqlCommand(sqlTim, con))
            {
                cmd.Parameters.AddWithValue("@maHD", txtmaHD.Text);

                if (txtmaHD.Text == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ HOÁ ĐƠN CẦN TÌM");
                    return;
                }

                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvHD.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG CÓ HOÁ ĐƠN CẦN TÌM");
                    }
                }
            }
        }

        private void dateLHD_ValueChanged(object sender, EventArgs e)
        {
            DateTime chonN = dateLHD.Value.Date;

            string connectionString = @"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True";
            string query = "SELECT maHD, ngayLap, tongTien,  tienKhachTra,  hoTen as 'Tên Nhân Viên', trangThai " +
                           "FROM HoaDon " +
                           "INNER JOIN NhanVien ON HoaDon.maNV = NhanVien.maNV " +
                           "WHERE CAST(ngayLap AS DATE) = @chonN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho truy vấn để tránh lỗ hổng bảo mật
                    command.Parameters.AddWithValue("@chonN", chonN);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvHD.DataSource = dt;
                    }
                    dr.Close();
                    connection.Close();
                }
            }
           
        }

        private void btKD_Click(object sender, EventArgs e)
        {
            dateLHD.ResetText();
            txtmaHD.ResetText();
            load();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (dgvHD.SelectedRows.Count > 0) // Kiểm tra xem người dùng đã chọn ít nhất một dòng hay không
            {
                string maHD = dgvHD.SelectedRows[0].Cells["maHD"].Value.ToString();

                // Mở form XemHD và truyền mã hoá đơn
                XemHD f2 = new XemHD();
                f2.ShowHDInfo(maHD);
                f2.ShowDialog();
            }
        }
   
    }
}
