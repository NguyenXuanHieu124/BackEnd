using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class NguyenLieu
    {
        public int NguyenLieuID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenNL { get; set; }
        [Required]
        [MaxLength(500)]
        public string MoTa { get; set; }
        [Required]
        public int Gia { get; set; }

        public virtual ICollection<TonKho> TonKhos { get; set; }
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }

    }
}