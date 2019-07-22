using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class Ban
    {
        public int BanID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenBan { get; set; }

        public int Status { get; set; }

        public virtual ICollection<HoaDonXuat> HoaDonXuats { get; set; }
    }
}