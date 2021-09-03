using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
   public class SanPham
    {
        private string maSP;
        private string tenSP;
        private int maDM;
        private double gia;
        private int soLuong;

        public SanPham(string msp, string tsp, int madm, double gia, int sl)
        {
            this.maSP = msp;
            this.tenSP = tsp;
            this.maDM = madm;
            this.Gia = gia;
            this.soLuong = sl;
        }
        public SanPham(DataRow row)
        {
            this.maSP = row["maSP"].ToString();
            this.tenSP = row["tenSP"].ToString();
            this.maDM = (int)row["maDM"];
            this.Gia= (double)row["gia"];
            this.soLuong = (int)row["soLuong"];
        }


        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int MaDM { get => maDM; set => maDM = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
