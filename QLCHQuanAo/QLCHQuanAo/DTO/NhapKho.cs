using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DTO
{
    public class NhapKho
    {
        private int id;
        private int maSP;
        private int soLuongNhap;
        private int donGiaNhap;
        private string ngayNhap;

        public NhapKho(int id, int msp, int sln, int dgn, string nn)
        {
            this.id = id;
            this.maSP = msp;
            this.soLuongNhap = sln;
            this.donGiaNhap = dgn;
            this.ngayNhap = nn;
        }
        public NhapKho(DataRow row)
        {
            this.id = (int)row["ID"];
            this.maSP = (int)row["maSP"];
            this.soLuongNhap = (int)row["soLuong"];
            this.donGiaNhap = (int)row["donGia"];
            this.ngayNhap = row["ngay"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public int DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}
