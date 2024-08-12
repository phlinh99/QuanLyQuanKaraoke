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
    public partial class QuanLyDichVu : Form
    {
        SqlConnection con;
        QuanLyDichVu qldv;
        public QuanLyDichVu()
        {
            InitializeComponent();
            qldv = new QuanLyDichVu(this);
        }
        public QuanLyDichVu(QuanLyDichVu qlDV)
        {
            qldv= qlDV;
        }

        private void dgvDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();          
            load();
            qldv.GetSizeColumn();
         
        }
        private void load()
        {
            using (SqlCommand cmd = new SqlCommand("exec hienThiDSDV", con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDV.DataSource = dt;
                }
            }
        }
        public void GetSizeColumn()
        {
            qldv.dgvDV.Columns[0].Width = 165;
            qldv.dgvDV.Columns[1].Width = 165;
            qldv.dgvDV.Columns[2].Width = 165;
            qldv.dgvDV.Columns[3].Width = 165;
            qldv.dgvDV.Columns[4].Width = 165;
            qldv.dgvDV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qldv.dgvDV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qldv.dgvDV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qldv.dgvDV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qldv.dgvDV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qldv.dgvDV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTKim_Click(object sender, EventArgs e)
        {

            string sqlTim = "SELECT * FROM DichVu WHERE tenDichVu LIKE '%' + @tenDichVu + '%'";
            using (SqlCommand cmd = new SqlCommand(sqlTim, con))
            {
                cmd.Parameters.AddWithValue("@tenDichVu", txtDV.Text);

                if (txtDV.Text == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ DỊCH VỤ CẦN TÌM");
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
                        dgvDV.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG CÓ DỊCH VỤ CẦN TÌM");
                    }
                }
            }
        }

        private void btKD_Click(object sender, EventArgs e)
        {
            txtDV.ResetText();
            load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            ThemDV f2 = new ThemDV();
            f2.ShowDialog();
            load();
        }

        private void btCN_Click(object sender, EventArgs e)
        {
            CapNhatDV f3 = new CapNhatDV();
            f3.txtmaDV.Text = this.dgvDV.CurrentRow.Cells[0].Value.ToString();
            f3.txtTDV.Text = this.dgvDV.CurrentRow.Cells[1].Value.ToString();
            f3.txtGia.Text = this.dgvDV.CurrentRow.Cells[2].Value.ToString();
            f3.txtSL.Text = this.dgvDV.CurrentRow.Cells[4].Value.ToString();
            f3.ShowDialog();
            load();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDV.CurrentRow != null)
            {
                string maDV = dgvDV.CurrentRow.Cells["maDV"].Value.ToString();
                string sqlXoa = "delete from DichVu where maDV= @maDV";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.Parameters.AddWithValue("@maDV", maDV);
                cmd.ExecuteNonQuery();
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
