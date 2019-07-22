using Quản_Lý_Coffee.Models;
using Quản_Lý_Coffee.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Quản_Lý_Coffee.Controllers
{
    public class LoaiSanPhamController : ApiController
    {
        /**
      * @api {get} api/getloaisp Get All loaisp
      * @apiName GetAllLoaiSanPham
      * @apiGroup LoaiSanPham
      *
      *
      * @apiSuccessExample Success-Response:
      *     HTTP/1.1 200 OK
      *    [
      *       {
      *            "LoaiSPID": 3,
      *            "TenLoai":Coffee
      *        },
      *        {   "LoaiSPID": 2,
      *            "TenLoai":Desert
      *        }
      *    ]
      *
      *
      * @apiError LoaiSanPhamNotFound The id of the LoaiSanPham was not found.
      *
      * @apiErrorExample Error-Response:
      *     HTTP/1.1 404 Not Found
      *     {
      *       "error": "NotFound"
      *     }
      */
        [HttpGet]
        [ActionName("getloaisp")]
     
        public IHttpActionResult GetLoaiSPs()
        {
            using(QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext())
            {
                var loaispdto = db.LoaiSPs.Select(
                          s => new LoaiSanPhamDTO { LoaiSPID = s.LoaiSPID, TenLoai = s.TenLoai })
                          .ToList();
                if (loaispdto.Count() == 0)
                    return NotFound();

                return Ok(loaispdto);
            }

        }
        /**
          * @api {get} /api/GetLoaiSanPhamByid/:id Get LoaiSanPham By Id
          * @apiVersion 0.1.0
          * @apiName GetLoaiSanPhamByid
          * @apiGroup LoaiSanPham
          *
          * @apiParam {Number} id LoaiSanPham unique ID.
          *
          * @apiSuccess {int} LoaiSPID Id of the c.
          * @apiSuccess {string} TenLoai  Id of the SanPham.
          *
          * @apiSuccessExample Success-Response:
          *     HTTP/1.1 200 OK
          *    {
      *            "LoaiSPID": 3,
      *            "TenLoai":Coffee
      *        }
          *
          * @apiError LoaiSanPhamNotFound The id of the LoaiSanPham was not found.
          *
          * @apiErrorExample Error-Response:
          *     HTTP/1.1 404 Not Found
          *     {
          *       "error": "LoaiSanPhamNotFound"
          *     }
          */
        [HttpGet]
        [ActionName("GetLoaiSanPhamByid")]
        public IHttpActionResult GetLoaiSanPhamByid(int id)
        {
         
            using (QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext())
            {
                LoaiSP loaisp = db.LoaiSPs.Find(id);
                if (loaisp == null)
                {
                    return NotFound();
                }
                LoaiSanPhamDTO lspdto = new LoaiSanPhamDTO()
                {
                    LoaiSPID = loaisp.LoaiSPID,
                    TenLoai = loaisp.TenLoai
                };
                return Ok(lspdto);
            }
        }


    }
}
