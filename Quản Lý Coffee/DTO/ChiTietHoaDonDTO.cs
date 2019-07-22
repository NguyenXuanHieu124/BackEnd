using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models.DTO
{
    public class ChiTietHoaDonDTO
    {
        public int ChiTietHoaDonID { get; set; }
        public int HoaDonXuatID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public string TenSanPham { get; set; }
    }
}