using QLCHQuanAo.DAO;
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
    public partial class fThanhToan : Form
    {
        private TaiKhoan taikhoandn;

        public TaiKhoan Taikhoandn { get => taikhoandn; set => taikhoandn = value; }
        public fThanhToan(TaiKhoan acc)
        {
            InitializeComponent();
            this.taikhoandn = acc;
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan f = new fThongTinTaiKhoan(taikhoandn);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fChiTietHoaDon f = new fChiTietHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            string query = "select maSP,tenSP,tenDM,gia,soLuong from SANPHAM inner join DANHMUC on SANPHAM.maDM = DANHMUC.maDM";
            dgvSPThanhToan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
