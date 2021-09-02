using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }

        private HoaDonDAO() { }


        public List<HoaDon> LaydsHD()
        {
            List<HoaDon> lhd = new List<HoaDon>();
            string query = "select * from HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDon hd = new HoaDon(item);
                lhd.Add(hd);
            }
            return lhd;
        }


    }
}
