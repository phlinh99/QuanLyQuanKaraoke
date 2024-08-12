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
    public partial class ThemDV : Form
    {
        SqlConnection con;
        private object newMaDV;

        public ThemDV()
        {
            InitializeComponent();
        }

        private void ThemDV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            List<string> trong = new List<string>();
           
            if (string.IsNullOrEmpty(txtTDV.Text.Trim()))
            {
                trong.Add("Tên dịch vụ");
            }
            if (string.IsNullOrEmpty(txtGia.Text.Trim()))
            {
                trong.Add("Giá dịch vụ");
            }
            if (string.IsNullOrEmpty(txtSL.Text.Trim()))
            {
                trong.Add("Số lượng dịch vụ");
            }
            if (trong.Count > 0)
            {
                string message = "Vui lòng nhập các thông tin sau:\n";
                message += string.Join("\n", trong);
                MessageBox.Show(message);
                return;
            }
            string lastMaDV = GetLastMaDVFromDatabase();
            // Sinh mã nhân viên mới từ mã dịch vụ cuối cùng
            string newMaDV = GenerateMaDV(lastMaDV);
            // Tiếp tục với việc thêm dịch vụ mới vào cơ sở dữ liệu
            string sqlThem = "INSERT INTO DichVu (maDV, donGia, donViTinh, soLuongDV, tenDichVu) " +
                              "VALUES (@maDV, @donGia, @donViTinh, @soLuongDV, @tenDichVu)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);

            // Gán giá trị cho các tham số
            cmd.Parameters.AddWithValue("@maDV", newMaDV);
            cmd.Parameters.AddWithValue("@donGia", txtGia.Text);
            cmd.Parameters.AddWithValue("@donViTinh", "VND");
            cmd.Parameters.AddWithValue("@soLuongDV", txtSL.Text.Trim());
            cmd.Parameters.AddWithValue("@tenDichVu", txtTDV.Text.Trim());        
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG");
            }
            else
            {
                MessageBox.Show("CẬP NHẬT KHÔNG THÀNH CÔNG");
            }
            this.Close();
        }
        private string GetLastMaDVFromDatabase()
        {
            string lastMaDV = "";
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                con.Open();
                string sql = "SELECT TOP 1 maDV FROM DichVu ORDER BY maDV DESC";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastMaDV = reader["maDV"].ToString();
                }
            }
            return lastMaDV;
        }
        private string GenerateMaDV(string lastMaDV)
        {
            string newMaDV = "";
            if (lastMaDV != "")
            {
                // Lấy phần số từ mã dịch vụ cuối cùng
                string lastNumberPart = lastMaDV.Substring(4); // Bỏ qua các ký tự đầu tiên để lấy phần số

                // Chuyển phần số thành số nguyên
                int lastNumber;
                if (int.TryParse(lastNumberPart, out lastNumber))
                {
                    // Tăng số nguyên lên một đơn vị
                    lastNumber++;

                    // Tạo mã mới từ phần đầu và số nguyên vừa tăng
                    newMaDV = "DVAA" + lastNumber.ToString("000"); // Format số nguyên thành chuỗi với 3 chữ số
                }
            }
            else
            {
                // Nếu không có mã dịch vụ cuối cùng, bắt đầu từ mã đầu tiên
                newMaDV = "DVAA001";
            }
            return newMaDV;
        }

        private void ThemDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
