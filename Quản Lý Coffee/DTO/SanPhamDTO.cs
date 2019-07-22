using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.Models.DTO
{
    public class SanPhamDTO
    {
        public int SanPhamID { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public int Gia { get; set; }
        public string LinkImage { get; set; }
        public int LoaiSPID { get; set; }
    }
}