using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models.DTO
{
    public class HoaDonXuatDTO
    {
        public int HoaDonXuatID { get; set; }
        public DateTime NgayGio { get; set; }
        public string HinhThucThanhToan { get; set; }
        public int TongTien { get; set; }
        public bool DaThanhToan { get; set; }
        public int ChiNhanhID { get; set; }
        public string TenBan { get; set; }
        public int BanID { get; set; }
        public string TenKhachHang { get; set; }
    }
}