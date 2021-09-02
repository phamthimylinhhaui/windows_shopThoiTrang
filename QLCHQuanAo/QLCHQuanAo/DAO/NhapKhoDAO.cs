using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
   public class NhapKhoDAO
    {
        private static NhapKhoDAO instance;
        public static NhapKhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhapKhoDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool nhapKho(int masp, int sl, int dgn, string nn)
        {
            string query = string.Format("INSERT into dbo.NHAPKHO (maSP, soLuong, donGia, ngay) VALUES (N'{0}', {1}, {2},'{3}')", masp, sl, dgn, nn);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
        private NhapKhoDAO() { }

        public List<NhapKho> LaydsNK()
        {
            List<NhapKho> lnk = new List<NhapKho>();
            string query = "select * from NHAPKHO";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhapKho nk = new NhapKho(item);
                lnk.Add(nk);
            }
            return lnk;
        }
        public bool XoaNK(int id)
        {
            string query = string.Format("DELETE dbo.NHAPKHO WHERE ID={0}", id);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
    }
}
