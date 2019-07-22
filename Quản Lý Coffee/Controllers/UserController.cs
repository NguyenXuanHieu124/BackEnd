using Quản_Lý_Coffee.DTO;
using Quản_Lý_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;

namespace Quản_Lý_Coffee.Controllers
{
    public class UserController : ApiController
    {

        private QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext();
        [HttpGet]
        [ActionName("getusers")]
        public IHttpActionResult GetUsers()
        {
            // trả về danh sách các user đã đăng ký
            try
            {
                return Ok(db.Users.ToList());
            }
            catch (Exception e) { throw e; }
        }

        [HttpGet]
        [ActionName("getuserbyusername")]
        public IHttpActionResult GetUserByUserName(string username)
        {
            // trả về thông tin của user theo username
            UserDTO user = null;
            try
            {
                user = db.Users.Where(x => x.UserName == username)
                    .Select(u => new UserDTO()
                {
                    Email = u.Email,
                    FullName = u.FullName,
                    UserName = u.UserName,
                    GioiTinh = u.GioiTinh,
                    NamSinh = u.NamSinh,
                    DienThoai = u.DienThoai,
                    DiaChi = u.DiaChi,
                }).FirstOrDefault<UserDTO>();
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(user);
                }

            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [ActionName("updateuser")]
        public IHttpActionResult UpdateUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("not a valid model");
            var user = db.Users.Where(s => s.UserName == userDTO.UserName)
                .FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            user.FullName = userDTO.FullName;
            user.Email = userDTO.Email;
            user.NamSinh = userDTO.NamSinh;
            user.GioiTinh = userDTO.GioiTinh;
            user.DiaChi = userDTO.DiaChi;
            user.DienThoai = userDTO.DienThoai;
            db.SaveChanges();
            return Ok();
        }
    }
}
