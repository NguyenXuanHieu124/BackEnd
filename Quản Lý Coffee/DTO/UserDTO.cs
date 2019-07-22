using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quản_Lý_Coffee.DTO
{
    public class UserDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime? NamSinh { get; set; }
        public Boolean GioiTinh { get; set; } 
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}