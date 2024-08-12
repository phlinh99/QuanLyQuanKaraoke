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
    public partial class ThemNV : Form
    {
        SqlConnection con;
        public ThemNV()
        {
            InitializeComponent();
        }

        
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThemNV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from LoaiNhanVien",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCV.DataSource = dt;
            cbCV.DisplayMember = "tenLoaiNhanVien";
            cbCV.ValueMember = "maLNV";
            cbCV.Text = "Chọn chức vụ";
            
        }
        
        private void ThemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {            
            List<string> trong = new List<string>();
            if (string.IsNullOrEmpty(cbGT.Text))
            {
                trong.Add("Giới tính");
            }
            if (string.IsNullOrEmpty(txthoT.Text.Trim()))
            {
                trong.Add("Tên nhân viên");
            }
            if (string.IsNullOrEmpty(txtDC.Text.Trim()))
            {
                trong.Add("Địa chỉ nhân viên");
            }
            if (string.IsNullOrEmpty(txtPW.Text.Trim()))
            {
                trong.Add("Mật khẩu tài khoản");
            }
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                trong.Add("Email nhân viên");
            }

            if (trong.Count > 0)
            {
                string message = "Vui lòng nhập các thông tin sau:\n";
                message += string.Join("\n", trong);
                MessageBox.Show(message);
                return; 
            }
            string lastMaNV = GetLastMaNVFromDatabase();
            // Sinh mã nhân viên mới từ mã nhân viên cuối cùng
            string newMaNV = GenerateMaNV(lastMaNV);
            // Tiếp tục với việc thêm nhân viên mới vào cơ sở dữ liệu
            string sqlThem = "INSERT INTO NhanVien (maNV, gioiTinh, hoTen, diaChi, ngaySinh, password, email, soDienThoai, maLNV) " +
                              "VALUES (@maNV, @gioiTinh, @hoTen, @diaChi, @ngaySinh, @password, @email, @soDienThoai, @maLNV)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);

            // Gán giá trị cho các tham số
            cmd.Parameters.AddWithValue("@maNV", newMaNV);
            cmd.Parameters.AddWithValue("@gioiTinh", cbGT.Text);
            cmd.Parameters.AddWithValue("@hoTen", txthoT.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txtDC.Text.Trim());
            cmd.Parameters.AddWithValue("@ngaySinh", date.Value);
            cmd.Parameters.AddWithValue("@password", txtPW.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
            cmd.Parameters.AddWithValue("@soDienThoai", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@maLNV", cbCV.SelectedValue);

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
        private string GetLastMaNVFromDatabase()
        {
            string lastMaNV = "";
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True")) 
            {
                con.Open();
                string sql = "SELECT TOP 1 maNV FROM NhanVien ORDER BY maNV DESC";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastMaNV = reader["maNV"].ToString();
                }
            }
            return lastMaNV;
        }
        private string GenerateMaNV(string lastMaNV)
        {
            string newMaNV = "";
            if (lastMaNV != "")
            {
                // Lấy phần số từ mã nhân viên cuối cùng
                string lastNumberPart = lastMaNV.Substring(4); // Bỏ qua các ký tự đầu tiên để lấy phần số

                // Chuyển phần số thành số nguyên
                int lastNumber;
                if (int.TryParse(lastNumberPart, out lastNumber))
                {
                    // Tăng số nguyên lên một đơn vị
                    lastNumber++;

                    // Tạo mã mới từ phần đầu và số nguyên vừa tăng
                    newMaNV = "NVAA" + lastNumber.ToString("000"); // Format số nguyên thành chuỗi với 3 chữ số
                }
            }
            else
            {
                // Nếu không có mã nhân viên cuối cùng, bắt đầu từ mã đầu tiên
                newMaNV = "NVAA001";
            }
            return newMaNV;
        }
    }
}
