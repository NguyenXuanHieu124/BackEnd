using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int ChiTietHoaDonID { get; set; }
        [Required]
        public int SoLuong { get; set; }

        public int HoaDonXuatID { get; set; }
        public virtual HoaDonXuat HoaDonXuat { get; set; }

        public int SanPhamID { get; set; }
        public virtual SanPham SanPham { get; set; }

    }
}