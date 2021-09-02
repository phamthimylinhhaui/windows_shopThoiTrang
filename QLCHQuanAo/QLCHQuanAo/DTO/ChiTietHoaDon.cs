using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
    class ChiTietHoaDon
    {
        private int ID;
        private int maHD;
        private int maSP;
        private int soLuong;

        public ChiTietHoaDon(int id, int mahd, int masp, int soluong)
        {
            this.ID = id;
            this.maHD = mahd;
            this.maSP = masp;
            this.soLuong = soluong;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.maHD = (int)row["maHD"];
            this.maSP = (int)row["maSP"];
            this.soLuong = (int)row["soLuong"];

        }

        public int Id { get => ID; set => ID= value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
