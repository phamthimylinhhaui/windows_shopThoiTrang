using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
    public class DanhMuc
    {
        private int maDM;
        private string tenDM;
        private DanhMuc(int mdm, string tdm)
        {
            this.maDM = mdm;
            this.TenDM = tdm;
        }
        public DanhMuc(DataRow row)
        {
            this.maDM = (int)row["maDM"];
            this.tenDM = row["tenDM"].ToString();
        }
        public int MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
    }
}
