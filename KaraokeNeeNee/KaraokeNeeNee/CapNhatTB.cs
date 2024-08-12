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
    public partial class CapNhatTB : Form
    {
        SqlConnection con;
        private string maTB;

        public CapNhatTB()
        {
            InitializeComponent();
        }
        public CapNhatTB(string maTB)
        {
            this.maTB = maTB;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            var maNV = Form1.Tentk();
            string sqlThem = "update ThietBi set maTB=@maTB, tenTB=@tenTB, tinhTrang=@tinhTrang, soLuongTB=@soLuongTB , maNV=@maNV where maTB=@maTB";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("@maTB",txtmaTB.Text);
            cmd.Parameters.AddWithValue("@tenTB", txtTB.Text.Trim());
            cmd.Parameters.AddWithValue("@tinhTrang", txtTT.Text.Trim());
            cmd.Parameters.AddWithValue("@soLuongTB", txtSL.Text.Trim());
            cmd.Parameters.AddWithValue("@maNV", maNV);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void CapNhatTB_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void ShowTBInfo(string maTB)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True")) 
            {
                // Mở kết nối
                connection.Open();
                string sqlQuery = "SELECT * FROM ThietBi WHERE maTB = @maTB";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Thêm tham số @MaHD vào câu truy vấn để truyền giá trị mã hoá đơn
                    command.Parameters.AddWithValue("@maTB", maTB);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dữ liệu không
                        if (reader.HasRows)
                        {
                            reader.Read();
                            // Gán thông tin từ dòng dữ liệu hiện tại cho các label hoặc control tương ứng trên form XemHD
                            txtmaTB.Text = reader["maTB"].ToString();
                            txtTB.Text = reader["tenTB"].ToString();
                            txtTT.Text = reader["tinhTrang"].ToString();
                            txtSL.Text = reader["soLuongTB"].ToString();
                            txtmaNV.Text = reader["maNV"].ToString();
                        
                        }
                    }
                }

                // Đóng kết nối sau khi sử dụng xong
                connection.Close();
            }
        }

        private void txtmaTB_Click(object sender, EventArgs e)
        {
           MessageBox.Show("KHÔNG ĐƯỢC THAY ĐỔI MÃ THIẾT BỊ");
        }

        private void txtmaNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KHÔNG ĐƯỢC THAY ĐỔI MÃ NHÂN VIÊN");
        }
    }
}
