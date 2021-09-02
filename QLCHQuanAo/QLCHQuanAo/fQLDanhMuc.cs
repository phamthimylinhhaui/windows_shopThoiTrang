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
    public partial class fQLDanhMuc : Form
    {
        public fQLDanhMuc()
        {
            InitializeComponent();
        }

        private void fQLDanhMuc_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = DanhMucDAO.Instance.LaydsDM();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            fQLDanhMuc_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text == "" )
            {
                MessageBox.Show(" Không được để trống tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tendm = txtTenDM.Text;
                
                if (DanhMucDAO.Instance.ThemDM(tendm))
                {
                    MessageBox.Show("Thêm danh mục thành công");
                    fQLDanhMuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thêm được danh mục này, vui lòng kiểm tra khóa chính", "thông báo lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text == "")
            {
                MessageBox.Show(" Không được để trống tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try { 
                    string tendm = txtTenDM.Text;
                    int madm = int.Parse(txtMaDM.Text);

                    if (DanhMucDAO.Instance.SuaDM(tendm,madm))
                    {
                        MessageBox.Show("Sửa danh mục thành công");
                        fQLDanhMuc_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Không sửa được danh mục này, có thể danh mục này không tồn tại!!", "thông báo lỗi");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                       
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try { 
                int madm = int.Parse(txtMaDM.Text);

                if (DanhMucDAO.Instance.XoaDM(madm))
                {
                    MessageBox.Show("Xóa danh mục thành công");
                    fQLDanhMuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Không sửa Xóa danh mục này, có thể danh mục này không tồn tại!!", "thông báo lỗi");
                }
            catch (Exception ex)
            {
                if(ex.Message.Contains("FK_maDM"))
                    MessageBox.Show("muốn xóa DANH MỤC này bạn cần xóa các SẢN PHẨM thuộc danh mục này trước nhé !!!","NOTE");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDanhMuc.CurrentRow.Index;
            txtMaDM.Text = dgvDanhMuc.Rows[i].Cells[0].Value.ToString();
            txtTenDM.Text = dgvDanhMuc.Rows[i].Cells[1].Value.ToString();
        }
        List<DanhMuc> TimDMbyTenDM(string tendm)
        {
            List<DanhMuc> l = new List<DanhMuc>();
            l = DanhMucDAO.Instance.timDMbytenDM(tendm);
            return l;
        }
        private void btnTimKiemDM_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = TimDMbyTenDM(txtTimKiem.Text);
        }
    }
    
}
