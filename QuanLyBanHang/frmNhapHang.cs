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
    public partial class frmNhapHang : Form
    {
        // ket noi csdl
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "NhapHang";
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            // nhap thong tin hang hoa và luu vao csdl bảng NhapHang
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            string strSQL = "INSERT INTO NhapHang(MaHH, TenHH, DVT, SoLuong) VALUES(@MaHH, @TenHH, @DVT, @SoLuong)";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text);
            cmd.Parameters.AddWithValue("@TenHH", txtTenHH.Text);
            cmd.Parameters.AddWithValue("@DVT", txtDVT.Text);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuongHH.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            // quay lai frmLuaChonChucNang
            frmLuaChonChucNang frmLCCN = new frmLuaChonChucNang();
            frmLCCN.Show();
            this.Hide();
        }
    }
}
