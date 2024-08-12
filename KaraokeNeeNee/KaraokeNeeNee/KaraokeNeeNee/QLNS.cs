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
    public partial class QLNS : Form
    {
       
        SqlConnection con;
        QLNS qlns;
        public QLNS()
        {
            InitializeComponent();
            qlns = new QLNS(this);
        }

        public QLNS(QLNS qLNS)
        {
            qlns = qLNS;
        }

        private void QLNS_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanVien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            load();
            qlns.GetSizeColumn();
        }
        private void load()
        {
            using (SqlCommand cmd = new SqlCommand("exec hienThiDS", con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaNV.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgv.CurrentRow.Cells[2].Value.ToString();        
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTKim_Click(object sender, EventArgs e)
        {

            string sqlTim = "select maNV, gioiTinh, hoTen, diaChi, ngaySinh, email, soDienThoai, tenLoaiNhanVien from NhanVien a join LoaiNhanVien b on a.maLNV = b.maLNV where maNV = @maNV and hoTen LIKE @hoTen";
            using (SqlCommand cmd = new SqlCommand(sqlTim, con))
            {
                cmd.Parameters.AddWithValue("@maNV", txtmaNV.Text);
                cmd.Parameters.AddWithValue("@hoTen", "%" + txtTen.Text + "%");

               if (txtmaNV.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ VÀ HỌ TÊN NHÂN VIÊN CẦN TÌM");
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
                        dgv.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG CÓ NHÂN VIÊN CẦN TÌM");
                    }
                }
            }
        }               

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa;
            if (string.IsNullOrEmpty(txtmaNV.Text) && string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                sqlXoa = "delete from NhanVien where maNV= '" + txtmaNV.Text + "'";
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlXoa, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            load();
        }

        private void btKD_Click(object sender, EventArgs e)
        {
            txtmaNV.ResetText();
            txtTen.ResetText();
            load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemNV f2 = new ThemNV();
            f2.ShowDialog();
            load();

        }

        private void btCN_Click(object sender, EventArgs e)
        {

            CapNhatNV f3 = new CapNhatNV();
            f3.txtma.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            f3.cbGT.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            f3.txthoT.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            f3.txtDC.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            f3.date.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            f3.txtPW.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();
            f3.txtemail.Text = this.dgv.CurrentRow.Cells[6].Value.ToString();
            f3.txtSDT.Text = this.dgv.CurrentRow.Cells[7].Value.ToString();
            f3.cbCV.Text = this.dgv.CurrentRow.Cells[8].Value.ToString();
            f3.ShowDialog();
            load();
        }
        public void GetSizeColumn()
        {
            qlns.dgv.Columns[2].Width =180;
            qlns.dgv.Columns[3].Width =150;
            qlns.dgv.Columns[6].Width = 150;
            qlns.dgv.Columns[8].Width = 150;

        }
    }
}
