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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDN = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            if (dangnhap(TenDN, MatKhau))
            {
                TaiKhoan taikhoandn = DangNhap_DAO.Instance.layTaiKhoaQuaTenHT(TenDN);//lay tai khoan theo ten hienthi nv
                if (taikhoandn.Loai == 0) {
                    MessageBox.Show("Đăng nhập thành công với vai trò người quản trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fAdmin f = new fAdmin(taikhoandn);
                     this.Hide();
                     f.ShowDialog();
                    this.Show();
                }
                if (taikhoandn.Loai == 1)
                {
                    MessageBox.Show("Đăng nhập thành công với vai trò nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fThanhToan f = new fThanhToan(taikhoandn);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
          
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
 

        }
        bool dangnhap(string TenDN, string MatKhau)
        {
            return DangNhap_DAO.Instance.dangnhap(TenDN, MatKhau);
        }
    }
}
