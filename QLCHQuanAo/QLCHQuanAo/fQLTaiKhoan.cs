using QLCHQuanAo.DAO;
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
    public partial class fQLTaiKhoan : Form
    {
        public fQLTaiKhoan()
        {
            InitializeComponent();
        }


        private void fQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource =TaiKhoanDAO.Instance.layDSTaiKhoan();
        }

      
        private void btnXem_Click(object sender, EventArgs e)
        {
            fQLTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTaiKhoan.CurrentRow.Index;
            txtTenTK.Text = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvTaiKhoan.Rows[i].Cells[1].Value.ToString();
            nmLoai.Text = dgvTaiKhoan.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "")
            {
                MessageBox.Show(" Không được để trống tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenht = txtTenTK.Text;
                string tennv = txtTenNV.Text;
                int loai = (int)nmLoai.Value;
                if (TaiKhoanDAO.Instance.ThemTK(tenht, tennv, loai))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    fQLTaiKhoan_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thêm được tài khoản, vui lòng kiểm tra lại", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try { 
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show(" Không được để trống tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tenht = txtTenTK.Text;
                    string tennv = txtTenNV.Text;
                    int loai = (int)nmLoai.Value;
                    if (TaiKhoanDAO.Instance.SuaTK(tenht, tennv, loai))
                    {
                        MessageBox.Show("Sửa tài khoản thành công");
                        fQLTaiKhoan_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Không Sửa được tài khoản, vui lòng kiểm tra lại", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try { 
            string tenht = txtTenTK.Text;
            if (TaiKhoanDAO.Instance.XoaTK(tenht))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                fQLTaiKhoan_Load(sender, e);
            }
            else
                MessageBox.Show("Không xóa được tài khoản, vui lòng kiểm tra lại", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DatlaiMK(string tenht)
        {
            if (TaiKhoanDAO.Instance.datLaiMatKhau(tenht))
            {
                MessageBox.Show("đặt lại mật khẩu tài khoản thành công");
            }
            else
                MessageBox.Show("Không đặt lại được mật khẩu, vui lòng kiểm tra lại", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            try
            {
                string tenht = txtTenTK.Text;
                DatlaiMK(tenht);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
