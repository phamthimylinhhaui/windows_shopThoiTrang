using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
    public class TaiKhoan
    {
        private string tenHT;
        private string tenNV;
        private string mk;
        private int loai;
        public TaiKhoan(string tenht, string tennv, int loai, string mk= null)
        {
            this.tenHT = tenht;
            this.tenNV = tennv;
            this.mk = mk;
            this.loai = loai;
        }

    public TaiKhoan(DataRow row)
        {
            this.tenHT = row["tenHienThiNV"].ToString();
            this.tenNV = row["tenNV"].ToString();
            this.loai = (int)row["loaiTK"];
            this.Mk = row["matKhau"].ToString();
        }

        public string TenHT { get => tenHT; set => tenHT = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Loai { get => loai; set => loai = value; }
        public string Mk { get => mk; set => mk = value; }
    }
}
