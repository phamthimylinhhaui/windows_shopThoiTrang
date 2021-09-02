using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
    public class HoaDon
    {
        private int maHD;
        private string ngay;
        private string sdtKH;
        private string tenKH;

        public int MaHD { get => maHD; set => maHD = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }

        public HoaDon(int mhd,  string n, string sdt, string tkh)
        {
            this.MaHD = mhd;
            this.Ngay = n;
            this.SdtKH = sdt;
            this.TenKH = tkh;
        }
        public HoaDon (DataRow row)
        {
            this.MaHD = (int)row["maHD"];
            this.Ngay = row["ngay"].ToString();
            this.SdtKH = row["sdtKH"].ToString();
            this.TenKH = row["tenKH"].ToString();
        }

       
    }
}
