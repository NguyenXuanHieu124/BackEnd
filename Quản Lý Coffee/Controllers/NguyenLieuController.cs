using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Quản_Lý_Coffee.Models;
using Quản_Lý_Coffee.DTO;

namespace Quản_Lý_Coffee.Controllers
{
    public class NguyenLieuController : ApiController
    {
        private QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext();

        // GET: api/NguyenLieu/GetNguyenLieus
        [HttpGet]
        [ActionName("GetNguyenLieus")]
        public IHttpActionResult GetNguyenLieus()
        {
            var nldto = db.NguyenLieus.Select(
                          s => new NguyenLieuDTO {
                              NguyenLieuID = s.NguyenLieuID,
                              Gia = s.Gia,
                              TenNL = s.TenNL,
                              MoTa = s.MoTa }).ToList();

            if (nldto.Count() == 0)
            {
                return NotFound();
            }
            else
                return Ok(nldto);
        }

        // GET: api/NguyenLieu/GetNguyenLieu/6
        [HttpGet]
        [ActionName("GetNguyenLieu")]
        [ResponseType(typeof(NguyenLieuDTO))]
        public IHttpActionResult GetNguyenLieu(int id)
        {
            NguyenLieu s = db.NguyenLieus.Find(id);
            if (s == null)
            {
                return NotFound();
            }
            // convert to DTO.
            NguyenLieuDTO hdndto = new NguyenLieuDTO { NguyenLieuID = s.NguyenLieuID, Gia = s.Gia, TenNL = s.TenNL, MoTa = s.MoTa };

            return Ok(hdndto);
        }


        // DELETE: api/NguyenLieu/DeleteNguyenLieu/6
        [ResponseType(typeof(NguyenLieu))]
        public IHttpActionResult DeleteNguyenLieu(int id)
        {
            NguyenLieu nguyenLieu = db.NguyenLieus.Find(id);
            if (nguyenLieu == null)
            {
                return NotFound();
            }

            db.NguyenLieus.Remove(nguyenLieu);
            db.SaveChanges();

            return Ok(nguyenLieu);
        }

    }
}