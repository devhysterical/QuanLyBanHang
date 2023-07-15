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
    public partial class frmQLNV : Form
    {
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "QuanLyNhanVien";
        public frmQLNV()
        {
            InitializeComponent();

        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            string strSQL = "SELECT * FROM QuanLyNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagvDanhSachNV.DataSource = dt;
            conn.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConnectionString))
            {
                conn.Open();
                bool EmptyField = false; // Biến kiểm tra có ô dữ liệu trống hay không

                foreach (DataGridViewRow row in datagvDanhSachNV.SelectedRows)
                {
                    // Nhập thông tin và lưu vào cơ sở dữ liệu
                    string MaNV = row.Cells[0].Value?.ToString(); // Sử dụng null-conditional operator '?'
                    string TenNV = row.Cells[1].Value?.ToString();
                    string NgaySinh = row.Cells[2].Value?.ToString();
                    string GioiTinh = row.Cells[3].Value?.ToString();
                    string Luong = row.Cells[4].Value?.ToString();

                    if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(TenNV) || string.IsNullOrEmpty(NgaySinh) || string.IsNullOrEmpty(GioiTinh) || string.IsNullOrEmpty(Luong))
                    {
                        EmptyField = true; // Có ô dữ liệu trống
                    }
                    else
                    {
                        string strSQL = "INSERT INTO QuanLyNhanVien(MaNV, Ten, NgaySinh, GioiTinh, Luong) VALUES('" + MaNV + "', '" + TenNV + "', '" + NgaySinh + "', '" + GioiTinh + "', '" + Luong + "')";

                        using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                if (EmptyField)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            LoadData();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            // user chọn dòng bất kì, xóa nhân viên dòng được chọn và cập nhật lại csdl
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            string strDelete = "Delete From QuanLyNhanVien Where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(strDelete, conn);
            cmd.Parameters.AddWithValue("@MaNV", datagvDanhSachNV.CurrentRow.Cells["MaNV"].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // thoát frmQLNV, hiển thị frmLuaChonChucNang
            frmLuaChonChucNang frmLCCN = new frmLuaChonChucNang();
            frmLCCN.Show();
            this.Close();
        }
    }
}
