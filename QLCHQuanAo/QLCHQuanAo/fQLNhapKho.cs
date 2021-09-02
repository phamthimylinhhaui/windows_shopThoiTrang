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
    public partial class fQLNhapKho : Form
    {
        public fQLNhapKho()
        {
            InitializeComponent();
        }

        private void fQLNhapKho_Load(object sender, EventArgs e)
        {
            dgvNhapKho.DataSource = NhapKhoDAO.Instance.LaydsNK();
        }

        private void dgvNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhapKho.CurrentRow.Index;
            txtID.Text = dgvNhapKho.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dgvNhapKho.Rows[i].Cells[1].Value.ToString();
            txtSoLuong.Text= dgvNhapKho.Rows[i].Cells[2].Value.ToString();
            txtDonGiaNhap.Text= dgvNhapKho.Rows[i].Cells[3].Value.ToString();
            dtpNgayNhap.Text = dgvNhapKho.Rows[i].Cells[4].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtSoLuong.Text == "" || txtDonGiaNhap.Text == "" || dtpNgayNhap.Text == "")
            {
                MessageBox.Show(" Không được để trống bất kỳ mục nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int masp = int.Parse(txtMaSP.Text);
                int sl = int.Parse(txtSoLuong.Text);
                int dgn = int.Parse(txtDonGiaNhap.Text);
                string ngay = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
                if (NhapKhoDAO.Instance.nhapKho(masp,sl, dgn, ngay))
                {
                    MessageBox.Show("Nhập kho thành công");
                    fQLNhapKho_Load(sender, e);
                }
                else
                    MessageBox.Show("Không nhập kho được, vui lòng kiểm tra lại", "thông báo lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(txtID.Text);
                if (NhapKhoDAO.Instance.XoaNK(id))
                {
                    MessageBox.Show("Xóa hóa đơn nhập kho thành công");
                    fQLNhapKho_Load(sender, e);
                }
                else
                    MessageBox.Show("Mã hóa đơn này không tồn tại trong kho dữ liệu", "thông báo lỗi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
