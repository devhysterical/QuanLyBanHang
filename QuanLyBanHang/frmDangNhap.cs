using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        // ket noi csdl
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "NhanVien";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // dua vao MaNV va Password từ bảng NhanVien của csdl QuanLyBanHang để kiểm tra đăng nhập hợp lệ hay không
            string strSQL = "SELECT * FROM NhanVien WHERE MaNV = @MaNV AND Password = @Password";
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@MaNV", txtUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            conn.Open();
            SqlDataReader dta = cmd.ExecuteReader();
            // kiểm tra đăng nhập
            if (dta.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                frmLuaChonChucNang frmLCCN = new frmLuaChonChucNang();
                frmLCCN.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // đóng kết nối
                conn.Close();
            }
        }
    }
}
