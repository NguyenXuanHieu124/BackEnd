using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models
{
    public class TonKho
    {
        public string TonKhoId { get; set; }
        [Required]
        public int Soluong { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }


    }
}