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
    public partial class QuanLyThietBi : Form
    {
        SqlConnection con;
        QuanLyThietBi qltb;
        public QuanLyThietBi()
        {
            InitializeComponent();
            qltb = new QuanLyThietBi(this);
        }
        public QuanLyThietBi(QuanLyThietBi qlTB)
        {
            qltb = qlTB;
        }
        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            load();
            qltb.GetSizeColumn();
        }
        private void load()
        {
            using (SqlCommand cmd = new SqlCommand("exec hienThiDSTB", con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTB.DataSource = dt;
                }
            }
            dgvTB.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);

        }


        public void GetSizeColumn()
        {
            qltb.dgvTB.Columns[0].Width = 165;
            qltb.dgvTB.Columns[1].Width = 165;
            qltb.dgvTB.Columns[2].Width = 165;
            qltb.dgvTB.Columns[3].Width = 165;
            qltb.dgvTB.Columns[4].Width = 190;
            qltb.dgvTB.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qltb.dgvTB.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qltb.dgvTB.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qltb.dgvTB.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qltb.dgvTB.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qltb.dgvTB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTKim_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT maTB, tenTB as 'Tên Thiết Bị' , soLuongTB as ' Số Lượng Thiết Bị', tinhTrang as 'Tình Trạng', hoTen as 'Tên Nhân Viên Cập Nhật' FROM ThietBi, NhanVien WHERE ThietBi.maNV = NhanVien.maNV and tenTB LIKE '%' + @tenTB + '%'";
            using (SqlCommand cmd = new SqlCommand(sqlTim, con))
            {
                cmd.Parameters.AddWithValue("@tenTB", txtTB.Text);

                if (txtTB.Text == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP TÊN THIẾT BỊ CẦN TÌM");
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
                        dgvTB.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG CÓ THIẾT BỊ CẦN TÌM");
                    }
                }
            }
        }
        private void btKD_Click(object sender, EventArgs e)
        {
            txtTB.ResetText();
            load();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvTB.CurrentRow != null)
            {
                string maTB = dgvTB.CurrentRow.Cells["maTB"].Value.ToString();
                string sqlXoa = "delete from ThietBi where maTB= @maTB";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.Parameters.AddWithValue("@maTB", maTB);
                cmd.ExecuteNonQuery();
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemTB f2 = new ThemTB();
            f2.ShowDialog();
            load();
        }

        private void btCN_Click(object sender, EventArgs e)
        {
            if (dgvTB.SelectedRows.Count > 0) // Kiểm tra xem người dùng đã chọn ít nhất một dòng hay không
            {
                string maTB = dgvTB.SelectedRows[0].Cells["maTB"].Value.ToString();
                CapNhatTB f2 = new CapNhatTB();
                f2.ShowTBInfo(maTB);
                f2.ShowDialog();
                load();
            }
        }

       
    }
}
