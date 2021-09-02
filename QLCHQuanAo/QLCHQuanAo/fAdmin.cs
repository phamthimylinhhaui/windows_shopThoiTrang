using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHQuanAo
{
    public partial class fAdmin : Form
    {
        private TaiKhoan taikhoandn;

        public TaiKhoan Taikhoandn { get => taikhoandn; set => taikhoandn = value; }

        public fAdmin(TaiKhoan acc)
        {
            InitializeComponent();
            this.taikhoandn = acc;
        }




// cai dat giao dien chuyen form qua lai
        private void loadPanelHienThi()
        {
            pHienThi.Controls.Clear();
            pHienThi.Visible = true;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLDoanhThu f = new fQLDoanhThu();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
          //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

            
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLSanPham f = new fQLSanPham();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
            //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLDanhMuc f = new fQLDanhMuc();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
            //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLTaiKhoan f = new fQLTaiKhoan();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
            //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLNhapKho f = new fQLNhapKho();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
            //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnQLDonHang_Click(object sender, EventArgs e)
        {
            loadPanelHienThi();
            fQLHoaDon f = new fQLHoaDon();
            f.TopLevel = false;
            pHienThi.Controls.Add(f);
            //  pHienThi.BorderStyle = BorderStyle.None;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
