using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class HoaDonNhap
    {
        public int HoaDonNhapID { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        [Required]
        public int TongTienNhap { get; set; }
        [Required]
        public int ChiNhanhID { get; set; }
        [Required]
        public int NguyenLieuID { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }

    }
}