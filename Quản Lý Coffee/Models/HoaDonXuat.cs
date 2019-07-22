using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class HoaDonXuat
    {
        [Key]
        public int HoaDonXuatID { get; set; }

        [Required]
        public DateTime NgayGio { get; set; }
        public string HinhThucThanhToan { get; set; }
        [Required]
        public int TongTien { get; set; }
        [Required]
        public bool DaThanhToan { get; set; }
        public string TenKhachHang { get; set; }
        [ForeignKey("ChiNhanh")]
        public int ChiNhanhID { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        [ForeignKey("Ban")]
        public int BanID { get; set; }
        public virtual Ban Ban { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    }
}