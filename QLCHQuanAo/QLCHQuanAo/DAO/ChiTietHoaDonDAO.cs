using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        internal static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }
        private ChiTietHoaDonDAO() { }



        // xóa chi tiết hóa đơn theo id
        public void XoaCTHDbyMasp(int id)
        {
            string query = string.Format("DELETE CHITIETHD WHERE maSP = {0}", id);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<ChiTietHoaDon> LaydsCTHD(int id)
        {
            List<ChiTietHoaDon> lct = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CHITIETHD WHERE ID=" + id);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon ct = new ChiTietHoaDon(item);
                lct.Add(ct);
            }
            return lct;
        }
    }
}
