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
    public partial class QLTK : Form
    {
        SqlConnection con;
        public QLTK()
        {
            InitializeComponent();
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();

        }
      
      private void load()
        {
            string connectionString = @"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True"; 
            string query = @" SELECT SUM(hd.tongTien)  FROM HOADON hd WHERE DAY(ngayLap) = '"+cbNgay.Text+ "' AND YEAR(ngayLap) = YEAR(GETDATE()) and month(ngayLap) = '" + cbThangg.Text + "' GROUP BY DAY(hd.ngayLap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                        txtDT.Text = result.ToString();                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi hoặc kết nối: " + ex.Message);
                }
            }
        }

        private void load1()
        {
            string connectionString = @"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True";
            string query = @" SELECT SUM(hd.tongTien) FROM HOADON hd WHERE month(ngayLap) ='" + cbThang.Text + "' and year(ngayLap) = '" + cbNam.Text + "' GROUP BY month(hd.ngayLap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                        txtDT2.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi hoặc kết nối: " + ex.Message);
                }
            }
        }

        private void load2()
        {
            string connectionString = @"Data Source=DESKTOP-DDN449I\LINH;Initial Catalog=KARAOKE_NEENEE;Integrated Security=True";
            string query = @" SELECT SUM(hd.tongTien) FROM HOADON hd WHERE year(ngayLap) = '" + cbNam2.Text + "' GROUP BY year(hd.ngayLap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                        txtDT3.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi hoặc kết nối: " + ex.Message);
                }
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNgay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON hd WHERE DAY(ngayLap) = '" + cbNgay.Text + "'  and month(ngayLap) = '" + cbThangg.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);          
            dgv.DataSource = dt;
            load();        
        }

        private void cbThangg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON hd WHERE DAY(ngayLap) = '" + cbNgay.Text + "'  and month(ngayLap) = '" + cbThangg.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            load();
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON hd WHERE month(ngayLap) = '"+cbThang.Text+ "' and year(ngayLap) = '"+cbNam.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv2.DataSource = dt;
            load1();
            
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON hd WHERE month(ngayLap) = '" + cbThang.Text + "' and year(ngayLap) = '" + cbNam.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv2.DataSource = dt;
            load1();
        }

        private void cbNam2_SelectedIndexChanged(object sender, EventArgs e)
        {           
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON hd WHERE year(ngayLap) = '" + cbNam2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv3.DataSource = dt;
            load2();
        }

        
    }
}
