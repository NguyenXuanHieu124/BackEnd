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
using Quản_Lý_Coffee.Models.DTO;

namespace Quản_Lý_Coffee.Controllers
{
    public class HoaDonNhapsController : ApiController
    {
        private QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext();

        // GET: api/HoaDonNhaps/GetHoaDonNhaps
           /**
            * @api {get} api/HoaDonNhaps Get All HoaDonNhaps
            * @apiName GetAllHoaDonNhap
            * @apiGroup HoaDonNhap
            *
            *
            * @apiSuccessExample Success-Response:
            *     HTTP/1.1 200 OK 
            *    [
            *       {
            *            "HoaDonNhapID": 3,
            *            "NgayNhap": "2018-11-27T00:00:00",
            *            "TongTienNhap": 12000,
            *            "ChiNhanhID": 1,
            *            "NguyenLieuID": 1,
            *            "SoLuong":2
            *        },
            *        {
            *            "HoaDonNhapID": 1,
            *            "NgayNhap": "2018-11-30T00:00:00",
            *            "TongTienNhap": 120000,
            *            "ChiNhanhID": 1,
            *            "NguyenLieuID": 1,
            *            "SoLuong":2
            *        }
            *    ]
            *     
            *
            * @apiError HoaDonNhapNotFound The id of the HoaDonNhap was not found.
            *
            * @apiErrorExample Error-Response:
            *     HTTP/1.1 404 Not Found
            *     {
            *       "error": "NotFound"
            *     }
            */
           [HttpGet]
           [ActionName("GetHoaDonNhaps")]
        public IHttpActionResult GetHoaDonNhaps()
        {
            var hdndto = db.HoaDonNhaps.Select(
                          s => new HoaDonNhapDTO { ChiNhanhID = s.ChiNhanh.ChiNhanhID, NgayNhap = s.NgayNhap, HoaDonNhapID = s.HoaDonNhapID, NguyenLieuID = s.NguyenLieu.NguyenLieuID, SoLuong = s.SoLuong, TongTienNhap = s.TongTienNhap })
                          .ToList();
            if (hdndto.Count() == 0)
            {
                return NotFound();
            }
            else
                return Ok(hdndto);
        }
     // GET: api/HoaDonNhaps/GetHoaDonNhap/6
       /**
       * @api {get} /api/HoaDonNhaps/:id Get HoaDonNhap By Id
       * @apiVersion 0.1.0
       * @apiName GetHoaDonNhapById
       * @apiGroup HoaDonNhap
       *
       * @apiParam {Number} id HoaDonNhap unique ID.
       *
       * @apiSuccessExample Success-Response:
       *     HTTP/1.1 200 OK
       *       {
       *            "HoaDonNhapID": 1,
       *            "NgayNhap": "2018-11-30T00:00:00",
       *            "TongTienNhap": 120000,
       *            "ChiNhanhID": 1,
       *            "NguyenLieuID": 1,
       *            "SoLuong":2
       *        }
       *
       * @apiError HoaDonNhapNotFound The id of the HoaDonNhap was not found.
       *     HTTP/1.1 404 Not Found
       *     {
       *       "error": "HoaDonNhapNotFound"
       *     }
       */
        [HttpGet]
        [ActionName("GetHoaDonNhap")]
        [ResponseType(typeof(HoaDonNhapDTO))]
        public IHttpActionResult GetHoaDonNhap(int id)
        {
            HoaDonNhap s = db.HoaDonNhaps.Find(id);
            if (s == null)
            {
                return NotFound();
            }
            // convert to DTO.
            HoaDonNhapDTO hdndto = new HoaDonNhapDTO { ChiNhanhID = s.ChiNhanh.ChiNhanhID, NgayNhap = s.NgayNhap, HoaDonNhapID = s.HoaDonNhapID, NguyenLieuID = s.NguyenLieu.NguyenLieuID, SoLuong = s.SoLuong, TongTienNhap = s.TongTienNhap };

            return Ok(hdndto);
        }


        // POST: api/HoaDonNhaps              (Create)
        /**
           * @api {post} api/HoaDonNhaps/  Create HoaDonNhap
           * @apiVersion 0.1.0
           * @apiName PostHoaDonNhap
           * @apiGroup HoaDonNhap
           * @apiParam {int} HoaDonNhapID Id of the HoaDonNhap.
           * @apiParam {int} NguyenLieuID  Id of the NguyenLieu.
           * @apiParam {int} SoLuong     Quantinty of the NguyenLieu.
           * @apiParam {int} ChiNhanhID  Id of the ChiNhanh.
           * @apiParam {DateTime} NgayNhap  Create day of the HoaDonNhap.
           * @apiParam {int} TongTienNhap  Total payment the HoaDonNhap.
           *
           * @apiSuccessExample Success-Response:
           *     HTTP/1.1 200 OK
           *      "Created Successfully"
           *
           * @apiError HoaDonNhapNotFound The HoaDonNhap was not found.
           *
           * @apiErrorExample Error-Response:
           *     HTTP/1.1 400 Bad Request
           *     {
           *       "error": "The server can not understand the request due to invalid syntax."
           *     }
           */
        //[ResponseType(typeof(HoaDonNhap))]
        public IHttpActionResult PostHoaDonNhap([FromBody] HoaDonNhap hoaDonNhap)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HoaDonNhaps.Add(hoaDonNhap);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hoaDonNhap.HoaDonNhapID }, hoaDonNhap);
        }

        
    }
}