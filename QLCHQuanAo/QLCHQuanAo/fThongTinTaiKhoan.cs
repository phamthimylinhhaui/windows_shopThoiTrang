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
    public partial class fThongTinTaiKhoan : Form
    {
        private TaiKhoan taikhoandn;
        public TaiKhoan Taikhoandn
        {
            get => taikhoandn;
            set { taikhoandn = value; ThayDoiTK(taikhoandn); }
        }
        public fThongTinTaiKhoan(TaiKhoan acc)
        {
            InitializeComponent();
            taikhoandn = acc;
        }
    void ThayDoiTK(TaiKhoan acc)
    {
            txtTenHT.Text =taikhoandn.TenHT;
            txtTenNV.Text = taikhoandn.TenNV;
    }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenHT.Text = taikhoandn.TenHT;
            txtTenNV.Text = taikhoandn.TenNV;
        }

        void CapNhat()
        {
            string tenht = txtTenHT.Text;
            string mk = txtMatKhau.Text;
            string mkm = txtMatKhauMoi.Text;
            string nl = txtNhapLai.Text;
            string tennv = txtTenNV.Text;

            if (!mkm.Equals(nl))
            {
                MessageBox.Show("Nhập lại mật khẩu chưa trùng khớp. Vui lòng nhập lại","thông báo");
            }
            else
            {
                if (TaiKhoanDAO.Instance.CapNhatTK(tenht , tennv , mk , mkm))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Nhập sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CapNhat();
        }
    }
}
