using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class SanPham
    {
        public int SanPhamID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenSP { get; set; }
        [Required]
        [MaxLength(500)]
        public string MoTa { get; set; }
        [Required]
        public int Gia { get; set; }
        [Required]
        public string LinkImage { get; set; }

        [ForeignKey("LoaiSP")]
        public int LoaiSPID { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }


    }
}