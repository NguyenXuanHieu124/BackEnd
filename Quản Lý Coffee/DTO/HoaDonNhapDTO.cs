using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models.DTO
{
    public class HoaDonNhapDTO
    {
        public int HoaDonNhapID { get; set; }
        public int NguyenLieuID { get; set; }
        public int ChiNhanhID { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TongTienNhap { get; set; }

    }
}