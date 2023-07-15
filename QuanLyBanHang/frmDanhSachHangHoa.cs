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
    public partial class frmDanhSachHangHoa : Form
    {
        private string strConnectionString = @"Data Source=LAMTUANKIET;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private string strTableName = "NhapHang";
        public frmDanhSachHangHoa()
        {
            InitializeComponent();
        }

        private void frmDanhSachHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + strTableName, conn);
            DataTable dt = new DataTable(strTableName);
            da.Fill(dt);
            datagrDSHH.DataSource = dt;
            conn.Close();
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            // user chon dòng hàng hóa bất kì và nhấn nút xóa sẽ xóa hàng được chọn và cập nhật lại csdl
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            string strDelete = "Delete From NhapHang Where MaHH = @MaHH";
            SqlCommand cmd = new SqlCommand(strDelete, conn);
            cmd.Parameters.AddWithValue("@MaHH", datagrDSHH.CurrentRow.Cells["MaHH"].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // hien thi frmLuaChonChucNang
            frmLuaChonChucNang frm = new frmLuaChonChucNang();
            frm.Show();
            this.Hide();
        }
    }
}
