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
    public partial class ThemTB : Form
    {
        SqlConnection con;
        private object newMaTB;

        public ThemTB()
        {
            InitializeComponent();
        }

        private void ThemTB_Load(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtTB.Text.Trim()))
            {
                trong.Add("Tên thiết bị");
            }
            if (string.IsNullOrEmpty(txtSL.Text.Trim()))
            {
                trong.Add("Số lượng thiết bị");
            }
            if (string.IsNullOrEmpty(txtTT.Text.Trim()))
            {
                trong.Add("Tình trạng thiết bị");
            }
            if (trong.Count > 0)
            {
                string message = "Vui lòng nhập các thông tin sau:\n";
                message += string.Join("\n", trong);
                MessageBox.Show(message);
                return;
            }
            string lastMaTB = GetLastMaTBFromDatabase();
            string newMaTB = GenerateMaTB(lastMaTB);
           
            string sqlThem = "INSERT INTO ThietBi (maTB, tenTB,tinhTrang, soLuongTB,  maNV) " +
                              "VALUES (@maTB, @tenTB,@tinhTrang, @soLuongTB,  @maNV)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            var maNV = Form1.Tentk();
            // Gán giá trị cho các tham số
            cmd.Parameters.AddWithValue("@maTB", newMaTB);
            cmd.Parameters.AddWithValue("@tenTB", txtTB.Text.Trim());
            cmd.Parameters.AddWithValue("@tinhTrang", txtTT.Text.Trim());
            cmd.Parameters.AddWithValue("@soLuongTB", txtSL.Text.Trim());
            cmd.Parameters.AddWithValue("@maNV",maNV);
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


        private string GetLastMaTBFromDatabase()
        {
            string lastMaTB = "";
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"))
            {
                con.Open();
                string sql = "SELECT TOP 1 maTB FROM ThietBi ORDER BY maTB DESC";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastMaTB = reader["maTB"].ToString();
                }
            }
            return lastMaTB;
        }
        private string GenerateMaTB(string lastMaTB)
        {
            string newMaTB = "";
            if (lastMaTB != "")
            {
                // Lấy phần số từ mã nhân viên cuối cùng
                string lastNumberPart = lastMaTB.Substring(2); 

                // Chuyển phần số thành số nguyên
                int lastNumber;
                if (int.TryParse(lastNumberPart, out lastNumber))
                {
                    // Tăng số nguyên lên một đơn vị
                    lastNumber++;

                    // Tạo mã mới từ phần đầu và số nguyên vừa tăng
                    newMaTB = "TB" + lastNumber.ToString("000"); 
                }
            }
            else
            {
                // Nếu không có mã nhân viên cuối cùng, bắt đầu từ mã đầu tiên
                newMaTB = "TB001";
            }
            return newMaTB;
        }

        private void ThemTB_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
