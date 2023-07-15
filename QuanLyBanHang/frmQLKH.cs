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
    public partial class frmQLKH : Form
    {
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "KhachHang";
        public frmQLKH()
        {
            InitializeComponent();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + strTableName, conn);
            DataTable dt = new DataTable(strTableName);
            da.Fill(dt);
            dtgvTTKH.DataSource = dt;
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // user nhập thông tin khách hàng mới và nhấn nút thêm sẽ thêm khách hàng mới vào csdl (txtMaKH, txtTenKH, txtDiaChi, txtSDT, txtEmail, txtCMND)
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            string strThem = "INSERT INTO KhachHang VALUES (@MaKH, @TenKH, @SoDT, @CMND, @Email, @DiaChi)";
            SqlCommand cmd = new SqlCommand(strThem, conn);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@SoDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDC.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // user chọn 1 dòng bất kì và có thể xóa, sau khi xóa sẽ cập nhật lại csdl
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            string strDelete = "Delete From KhachHang Where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(strDelete, conn);
            cmd.Parameters.AddWithValue("@MaKH", dtgvTTKH.CurrentRow.Cells["MaKH"].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // hiển thị frmLuaChonChucNang
            frmLuaChonChucNang frm = new frmLuaChonChucNang();
            frm.Show();
            this.Hide();
        }
    }
}
