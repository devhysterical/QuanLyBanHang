using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmLuaChonChucNang : Form
    {
        public frmLuaChonChucNang()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            // hiển thị frmQLNV
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.Show();
            this.Hide();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            // hiển thị frmNhapHang
            frmNhapHang frmNH = new frmNhapHang();
            frmNH.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            // hiển thị frmQLKH
            frmQLKH frmQLKH = new frmQLKH();
            frmQLKH.Show();
            this.Hide();
        }

        private void btnNhapHD_Click(object sender, EventArgs e)
        {
            // hiển thị frmNhapHoaDonMuaHang
            frmNhapHD frmNHDMH = new frmNhapHD();
            frmNHDMH.Show();
            this.Hide();
        }

        private void btnDSHH_Click(object sender, EventArgs e)
        {
            frmDanhSachHangHoa frmDSHH = new frmDanhSachHangHoa();
            frmDSHH.Show();
            this.Hide();
        }
    }
}
