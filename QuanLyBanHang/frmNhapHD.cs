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
    public partial class frmNhapHD : Form
    {
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "HoaDon";
        private string useTableName = "KhachHang";
        private string useTableName2 = "NhapHang";
        public frmNhapHD()
        {
            InitializeComponent();

        }

        private void frmNhapHD_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKhachHangData();
            LoadNhapHangData();

        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + strTableName, conn);
            DataTable dt = new DataTable(strTableName);
            da.Fill(dt);
            dtgvHoaDon.DataSource = dt;
            conn.Close();
        }

        private void LoadKhachHangData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH FROM " + useTableName, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            conn.Close();
        }

        private void LoadNhapHangData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHH FROM " + useTableName2, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaHH.DataSource = dt;
            cbMaHH.DisplayMember = "MaHH";
            cbMaHH.ValueMember = "MaHH";
            conn.Close();
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaKH = cbMaKH.SelectedValue.ToString();
            (dtgvHoaDon.DataSource as DataTable).DefaultView.RowFilter = $"MaKH = '{selectedMaKH}'";
        }

        private void cbMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHH = cbMaHH.SelectedValue.ToString();
            (dtgvHoaDon.DataSource as DataTable).DefaultView.RowFilter = $"MaHH = '{selectedMaHH}'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm hóa đơn vào csdl bảng HoaDon
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in dtgvHoaDon.SelectedRows)
                {
                    string MaxHD = row.Cells[0].Value?.ToString();
                    string MaKH = row.Cells[1].Value?.ToString();
                    string MaHH = row.Cells[2].Value?.ToString();
                    string NgayMuaHang = row.Cells[3].Value?.ToString();
                    string SoLuong = row.Cells[4].Value?.ToString();
                    string DonGia = row.Cells[5].Value?.ToString();
                    string ThanhTien = row.Cells[6].Value?.ToString();
                    if (string.IsNullOrEmpty(MaxHD) || string.IsNullOrEmpty(MaKH) || string.IsNullOrEmpty(MaHH) || string.IsNullOrEmpty(NgayMuaHang) || string.IsNullOrEmpty(SoLuong) || string.IsNullOrEmpty(DonGia) || string.IsNullOrEmpty(ThanhTien))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string strSQL = "INSERT INTO HoaDon(MaxHD, MaKH, MaHH, NgayMuaHang, SoLuong, DonGia, ThanhTien) VALUES(@MaxHD, @MaKH, @MaHH, @NgayMuaHang, @SoLuong, @DonGia, @ThanhTien)";
                        SqlCommand cmd = new SqlCommand(strSQL, connection);
                        cmd.Parameters.AddWithValue("@MaxHD", MaxHD);
                        cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@MaHH", MaHH);
                        cmd.Parameters.AddWithValue("@NgayMuaHang", NgayMuaHang);
                        cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                        cmd.Parameters.AddWithValue("@DonGia", DonGia);
                        cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connection.Close();
            }
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Hiện tại vẫn chưa làm được phần này
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // quy lai frmLuaChonChucNang
            this.Hide();
            frmLuaChonChucNang frm = new frmLuaChonChucNang();
            frm.Show();
        }
    }
}
