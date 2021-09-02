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
    public partial class fQLHoaDon : Form
    {
        public fQLHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChiTietHoaDon f = new fChiTietHoaDon();
            f.Show();
        }

        private void fQLHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDonDAO.Instance.LaydsHD();
        }

        private void dgvHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvHoaDon.CurrentRow.Index;
            txthd.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            txtnl.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
            txtkh.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            txtsdt.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
        }
    }
}
