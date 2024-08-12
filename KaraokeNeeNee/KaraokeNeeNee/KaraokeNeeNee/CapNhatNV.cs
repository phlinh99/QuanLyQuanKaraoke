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
    public partial class CapNhatNV : Form
    {
        SqlConnection con;
        public CapNhatNV()
        {
            InitializeComponent();
        }

        private void CapNhatNV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from LoaiNhanVien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCV.DataSource = dt;
            cbCV.DisplayMember = "tenLoaiNhanVien";
            cbCV.ValueMember = "maLNV";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string sqlThem = "update NhanVien set gioiTinh=@gioiTinh, hoTen=@hoTen, diaChi=@diaChi, ngaySinh=@ngaySinh, password=@password, email=@email, soDienThoai=@soDienThoai, maLNV=@maLNV where maNV=@maNV";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("@maNV", txtma.Text.Trim());
            cmd.Parameters.AddWithValue("@gioiTinh", cbGT.Text);
            cmd.Parameters.AddWithValue("@hoTen", txthoT.Text);
            cmd.Parameters.AddWithValue("@diaChi", txtDC.Text);
            cmd.Parameters.AddWithValue("@ngaySinh", date.Value);
            cmd.Parameters.AddWithValue("@password", txtPW.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@soDienThoai", txtSDT.Text);
            cmd.Parameters.AddWithValue("@maLNV", cbCV.SelectedValue);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void cbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCV.Text = "Chọn chức vụ";
        }

        private void txtma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KHÔNG ĐƯỢC THAY ĐỔI MÃ NHÂN VIÊN");
        }
    }
}
