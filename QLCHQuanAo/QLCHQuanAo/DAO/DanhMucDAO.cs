using QLCHQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucDAO();
                return instance;
            }
            private set => instance = value;
        }

        private DanhMucDAO() { }

        public List<DanhMuc> LaydsDM()
        {
            List<DanhMuc> ldm = new List<DanhMuc>();
            string query = "select * from DANHMUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMuc dm = new DanhMuc(item);
                ldm.Add(dm);
            }
            return ldm;
        }
        public bool ThemDM(string tendm)
        {
            string query = string.Format("INSERT dbo.DANHMUC (tenDM) VALUES (N'{0}')", tendm);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }
        public bool SuaDM(string tendm, int madm)
        {
            string query = string.Format("UPDATE dbo.DANHMUC SET tenDM=N'{0}' WHERE maDM={1}", tendm, madm);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }

        //cần chú ý xóa thêm cả bản ghi của bảng sp vì có khóa
        public bool XoaDM( int madm)
        {
            string query = string.Format("DELETE dbo.DANHMUC WHERE maDM={0}", madm);
            int kq = DataProvider.Instance.ExecuteNoQuery(query);
            return kq > 0;
        }

        public List<DanhMuc> timDMbytenDM(string tendm)
        {
            List<DanhMuc> ldm = new List<DanhMuc>();
            string query = string.Format("SELECT * from dbo.DANHMUC WHERE tenDM LIKE N'%{0}%'", tendm);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMuc dm = new DanhMuc(item);
                ldm.Add(dm);
            }
            return ldm;

        }
    }
}   
