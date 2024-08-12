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
    public partial class CapNhatDV : Form
    {
        SqlConnection con;
        public CapNhatDV()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string sqlThem = "update DichVu set donGia=@donGia, donViTinh=@donViTinh, soLuongDV=@soLuongDV, tenDichVu=@tenDichVu where maDV=@maDV";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("@donGia", txtGia.Text);
            cmd.Parameters.AddWithValue("@donViTinh", "VND");
            cmd.Parameters.AddWithValue("@soLuongDV", txtSL.Text.Trim());
            cmd.Parameters.AddWithValue("@tenDichVu", txtTDV.Text.Trim());
            cmd.Parameters.AddWithValue("@maDV", txtmaDV.Text.Trim());

            cmd.ExecuteNonQuery();

            this.Close();
        }

        private void CapNhatDV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void txtmaDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KHÔNG ĐƯỢC THAY ĐỔI MÃ DỊCH VỤ");
        }

      
    }
}
