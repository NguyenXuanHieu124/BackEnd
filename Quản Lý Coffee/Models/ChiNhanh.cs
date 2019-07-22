using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class ChiNhanh
    {
        public int ChiNhanhID { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenCN { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        [MaxLength(200)]
        public string DiaChi { get; set; }


        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual ICollection<HoaDonXuat> HoaDonXuats { get; set; }
        public virtual ICollection<TonKho> TonKhos { get; set; }

    }
}