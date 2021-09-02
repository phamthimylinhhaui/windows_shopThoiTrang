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
    public partial class fQLSanPham : Form
    {
        public fQLSanPham()
        {
            InitializeComponent();
        }

        private void fQLSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamDAO.Instance.LaydsSanPham();
            loadDanhMucCBB(cbbDanhMuc);
        }
        
        void loadDanhMucCBB(ComboBox cb)
        {
            cb.DataSource = DanhMucDAO.Instance.LaydsDM();
            cb.DisplayMember = "tenDM";
        }
        
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSanPham.CurrentRow.Index;
            txtMaSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
            cbbDanhMuc.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
            nmSoLuongsp.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || cbbDanhMuc.Text==""|| txtDonGia.Text == ""|| nmSoLuongsp.Text == "")
            {
                MessageBox.Show(" Không được để trống bất kỳ mục nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string tensp = txtTenSP.Text;
                int madm = (cbbDanhMuc.SelectedItem as DanhMuc).MaDM;
                double gia = double.Parse(txtDonGia.Text);
                int sl = (int)nmSoLuongsp.Value;
                if (SanPhamDAO.Instance.ThemSP(tensp, madm, gia, sl))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    fQLSanPham_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thêm được sản phẩm này, vui lòng kiểm tra khóa chính", "thông báo lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || cbbDanhMuc.Text == "" || txtDonGia.Text == "" || nmSoLuongsp.Text == "")
            {
                MessageBox.Show(" Không được để trống bất kỳ mục nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try { 
                    string tensp = txtTenSP.Text;
                    int madm = (cbbDanhMuc.SelectedItem as DanhMuc).MaDM;
                    double gia = double.Parse(txtDonGia.Text);
                    int sl = (int)nmSoLuongsp.Value;
                    int masp = int.Parse(txtMaSP.Text);
                    if (SanPhamDAO.Instance.SuaSP(tensp, madm, gia, sl, masp))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công");
                        fQLSanPham_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Không sửa được sản phẩm này, vui lòng kiểm tra khóa chính", "thông báo lỗi");
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
            int masp = int.Parse(txtMaSP.Text);
            if (SanPhamDAO.Instance.XoaSP(masp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                fQLSanPham_Load(sender, e);
            }
            else
                MessageBox.Show("Không xóa được sản phẩm này, vui lòng kiểm tra lại", "thông báo lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        List<SanPham> TimSPbyTensp(string tensp)
        {
            List<SanPham> l = new List<SanPham>();
            l= SanPhamDAO.Instance.timSPbytensp(tensp);
            return l;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = TimSPbyTensp(txtTimKiem.Text);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            fQLSanPham_Load(sender, e);
        }
    }
}
