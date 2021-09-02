using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHQuanAo.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAO() { }

        public bool CapNhatTK(string tenht, string tennv, string mk, string mkm)//sua thong tin ca nhan
        {
            int kq = DataProvider.Instance.ExecuteNoQuery("exec CAPNHATTK @tenht , @tennv , @mk , @mkm", new object[] { tenht, tennv, mk, mkm });
            return kq > 0;
        }

        //thực hiện nhiệm vụ quản lý tài khoản
        public DataTable layDSTaiKhoan()//không lấy mật khẩu
        {
            return DataProvider.Instance.ExecuteQuery("select tenHienThiNV, tenNV, loaiTK from TAIKHOAN");
        }

        public bool ThemTK(string tenht, string tennv,int loai)
        {
            string query = string.Format("INSERT into dbo.TAIKHOAN (tenHienThiNV, tenNV, loaiTK) VALUES (N'{0}',N'{1}', {2})", tenht, tennv, loai) ;
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }

        public bool SuaTK(string tenht, string tennv, int loai)
        {
            string query = string.Format("UPDATE dbo.TAIKHOAN SET tenNV=N'{0}', loaiTK={1} WHERE tenHienThiNV=N'{2}'",tennv,loai, tenht);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
        // xoa sp cần sử lý thêm cái chi tiết hóa đơn vì nó có rằng buộc
        public bool XoaTK(string tenht)
        {
           
            string query = string.Format("DELETE TAIKHOAN WHERE tenHienThiNV = N'{0}' ", tenht);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
    }
}
