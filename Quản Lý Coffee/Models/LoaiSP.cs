using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class LoaiSP
    {
        public int LoaiSPID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}