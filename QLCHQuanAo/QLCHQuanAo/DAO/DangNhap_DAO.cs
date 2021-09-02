using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    public class DangNhap_DAO
    {
        private static DangNhap_DAO instance;

        public static DangNhap_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhap_DAO();
                return instance;
            }
            private set => instance = value;
        }
        private DangNhap_DAO() { }

        // kiem tra xem tai khoan dang nhap co trong bang TAIKHOAN 
        public bool dangnhap(string tendn, string matkhau)
        {
            string query = "select * from TAIKHOAN where tenHienThiNV = N'"+tendn+"' ";
            DataTable kq = DataProvider.Instance.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }

        // lay tai dl tu class tai khoan
        public TaiKhoan layTaiKhoaQuaTenHT(string tenht)
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("select * from TAIKHOAN where tenHienThiNV= N'" + tenht + "'");
            foreach (DataRow item in data.Rows)// chay lan luot cac dl trong bang
            {
                return new TaiKhoan(item);
            }
            return null;
        }

       
    }
}
