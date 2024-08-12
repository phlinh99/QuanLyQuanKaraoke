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
    public partial class XemHD : Form
    {
        SqlConnection con;
        private string maHD;

        public XemHD()
        {
            InitializeComponent();
        }

        public XemHD(string maHD)
        {
            this.maHD = maHD;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowHDInfo(string maHD)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True")) // Thay connection_string bằng chuỗi kết nối của bạn
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy thông tin của hoá đơn dựa trên mã hoá đơn
                string sqlQuery = "SELECT maHD, maP, gioNhanPhong, gioTraPhong, ngayLap, thue,tienKhachTra, tongTien, hoTen as 'Tên Nhân Viên', maLP " +
                           "FROM HoaDon " +
                           "INNER JOIN NhanVien ON HoaDon.maNV = NhanVien.maNV " +
                           "WHERE maHD = @maHD";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Thêm tham số @MaHD vào câu truy vấn để truyền giá trị mã hoá đơn
                    command.Parameters.AddWithValue("@maHD", maHD);
                    // Tạo đối tượng SqlDataReader để đọc dữ liệu từ câu truy vấn
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dữ liệu không
                        if (reader.HasRows)
                        {
                            // Di chuyển con trỏ đọc đến dòng đầu tiên
                            reader.Read();

                            // Gán thông tin từ dòng dữ liệu hiện tại cho các label hoặc control tương ứng trên form XemHD
                            lbmaHD.Text = reader["maHD"].ToString();
                            lbmaP.Text = reader["maP"].ToString();
                            lbNP.Text = reader["gioNhanPhong"].ToString();
                            lbTP.Text = reader["gioTraPhong"].ToString();
                            lbNL.Text = reader["ngayLap"].ToString();
                            lbThue.Text = reader["thue"].ToString();
                            lbKT.Text = reader["tienKhachTra"].ToString();
                            lbTT.Text = reader["tongTien"].ToString();
                            lbNV.Text = reader["Tên Nhân Viên"].ToString();
                            lbmaLP.Text = reader["maLP"].ToString();
                        }
                    }
                }

                // Đóng kết nối sau khi sử dụng xong
                connection.Close();
            }

        }
    }
}
