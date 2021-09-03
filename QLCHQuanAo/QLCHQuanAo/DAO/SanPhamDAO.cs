using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        internal static SanPhamDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
            private set => instance = value;
        }
        private SanPhamDAO() { }

        public List<SanPham> LaydsSanPham()
        {
            List<SanPham> lsp = new List<SanPham>();
            string query = "select * from SANPHAM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sp = new SanPham(item);
                lsp.Add(sp);
            }
            return lsp;
        }

       

        public bool ThemSP(string tensp, int madm, double gia, int soluong)
        {
            string query = string.Format("INSERT dbo.SANPHAM (tenSP, maDM, gia, soLuong) VALUES (N'{0}', {1}, {2}, {3})", tensp, madm, gia, soluong);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }

        public bool SuaSP( string tensp, int madm, double gia, int soluong, int masp)
        {
            string query = string.Format("UPDATE dbo.SANPHAM SET tenSP=N'{0}', maDM={1}, gia={2}, soLuong={3} WHERE maSP={4}", tensp, madm, gia, soluong, masp);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
        // xoa sp cần sử lý thêm cái chi tiết hóa đơn vì nó có rằng buộc
        public bool XoaSP(int masp)
        {
            ChiTietHoaDonDAO.Instance.XoaCTHDbyMasp(masp);
            string query = string.Format("DELETE SANPHAM WHERE maSP = {0}",masp);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }

        public List<SanPham> timSPbytensp(string tensp)
        {
            List<SanPham> lsp = new List<SanPham>();
            string query = string.Format("SELECT * from dbo.SANPHAM WHERE tenSP LIKE N'%{0}%'", tensp);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sp = new SanPham(item);
                lsp.Add(sp);
            }
            return lsp;
        }
    }
}
