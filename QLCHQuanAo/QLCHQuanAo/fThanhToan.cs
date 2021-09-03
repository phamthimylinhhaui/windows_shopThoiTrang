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
            MessageBox.Show("Thanh toán thành công : "+tongTien.ToString()+" VND","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            fThanhToan f = new fThanhToan(taikhoandn);
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        /* private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
         {
             this.Close(); 
         }*/

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            dgvSPThanhToan.DataSource = SanPhamDAO.Instance.LaydsSanPham();
           
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            fThanhToan_Load(sender, e);
            clear();
        }
        void clear()
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtTimKiem.Clear();
            nmSoLuong.Value = 1;
        }
    /*    void loadDanhMucCBB(ComboBox cb)
        {
            cb.DataSource = DanhMucDAO.Instance.LaydsDM();
            cb.DisplayMember = "tenDM";
        }*/

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSPThanhToan.DataSource = TimSPbyTensp(txtTimKiem.Text);
        }
        List<SanPham> TimSPbyTensp(string tensp)
        {
            List<SanPham> l = new List<SanPham>();
            l = SanPhamDAO.Instance.timSPbytensp(tensp);
            return l;
        }

       

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSPThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSPThanhToan.CurrentRow.Index;
            txtmasp.Text = dgvSPThanhToan.Rows[i].Cells[0].Value.ToString();
            txttensp.Text = dgvSPThanhToan.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dgvSPThanhToan.Rows[i].Cells[4].Value.ToString();
        }

        public static int tongTien;
        private void btnThemVaoGH_Click(object sender, EventArgs e)
        {
            try
            {
                int a =int.Parse(txtDonGia.Text);
                 int dongia = a * int.Parse(nmSoLuong.Value.ToString());
                 int i = lvGioHang.Items.Count;
             
                 lvGioHang.Items.Add(txtmasp.Text);
                 lvGioHang.Items[i].SubItems.Add(txttensp.Text);
                 lvGioHang.Items[i].SubItems.Add(nmSoLuong.Value.ToString());
                 lvGioHang.Items[i].SubItems.Add(dongia.ToString());
                // hiện tổng tiền
                tongTien = tongTien + int.Parse(lvGioHang.Items[i].SubItems[3].Text);
                txtTongTien.Text = tongTien.ToString();
            }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            tongTien = tongTien - (tongTien * int.Parse(nmGiamGia.Value.ToString()) / 100);
            
            txtTongTien.Text = tongTien.ToString();
        }
    }
}
