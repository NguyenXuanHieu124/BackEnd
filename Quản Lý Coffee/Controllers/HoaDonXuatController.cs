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
    public class HoaDonXuatController : ApiController
    {
        /**
       * @api {get} api/HoaDonXuat/gethoadonxuats Get All HoaDonXuat
       * @apiName GetAllHoaDonXuat
       * @apiGroup HoaDonXuat
       *
       *
       * @apiSuccessExample Success-Response:
       *     HTTP/1.1 200 OK
       *     [
       *       {
       *            "HoaDonXuatID": 3,
       *            "NgayGio": "2018-11-27T00:00:00",
       *            "HinhThucThanhToan": null,
       *            "TongTien": 0,
       *            "DaThanhToan": false,
       *            "ChiNhanhID": 1,
       *            "BanID": 1,
       *            "TenKhachHang":"Mr.Quynh"
       *        },
       *        {
       *            "HoaDonXuatID": 2,
       *            "NgayGio": "2018-11-27T00:00:00",
       *            "HinhThucThanhToan": null,
       *            "TongTien": 0,
       *            "DaThanhToan": false,
       *            "ChiNhanhID": 1,
       *            "BanID": 2,
       *            "TenKhachHang":"Mr.Quynh"
       *        }
       *    ]
       *     
       *
       * @apiError HoaDonXuatNotFound The id of the HoaDonXuat was not found.
       *
       * @apiErrorExample Error-Response:
       *     HTTP/1.1 404 Not Found
       *     {
       *       "error": "NotFound"
       *     }
       */
        [HttpGet]
        [ActionName("gethoadonxuats")]
        public IHttpActionResult GetHoaDonXuats()
        {
       
            using (QuanLyCoffeeDbContext db = new QuanLyCoffeeDbContext())
            {
                var hoadonxuatdto = db.HoaDonXuats.Select(
                          hdx => new HoaDonXuatDTO
                          {
                              HoaDonXuatID = hdx.HoaDonXuatID,
                              BanID = hdx.Ban.BanID,
                              ChiNhanhID = hdx.ChiNhanh.ChiNhanhID,
                              HinhThucThanhToan = hdx.HinhThucThanhToan,
                              NgayGio = hdx.NgayGio,
                              TongTien = hdx.TongTien,
                              TenKhachHang = hdx.TenKhachHang,
                          }).ToList();
                if (hoadonxuatdto.Count == 0)
                {
                    return NotFound();
                }
                return Ok(hoadonxuatdto);
            }
        }

        /**
            * @api {get} /api/HoaDonXuat/getbyid/:id Get HoaDonXuat By Id
            * @apiVersion 0.1.0
            * @apiName GetHoaDonXuatById
            * @apiGroup HoaDonXuat
            *
            * @apiParam {Number} id HoaDonXuat unique ID.
            *
            * @apiSuccessExample Success-Response:
            *     HTTP/1.1 200 OK
            *       {
            *            "HoaDonXuatID": 2,
            *            "NgayGio": "2018-11-27T00:00:00",
            *            "HinhThucThanhToan": null,
            *            "TongTien": 0,
            *            "DaThanhToan": false,
            *            "ChiNhanhID": 1,
            *            "BanID": 2,
            *            "TenKhachHang":"Mr.Quynh"
            *       }
            *
            * @apiError HoaDonXuatNotFound The id of the HoaDonXuat was not found.
            *
            * @apiErrorExample Error-Response:
            *     HTTP/1.1 404 Not Found
            *     {
            *       "error": "HoaDonXuatNotFound"
            *     }
            */
        [HttpGet]
        [ActionName("getbyid")]
        public IHttpActionResult GetById(int id)
        {
           
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                HoaDonXuat hdx = entities.HoaDonXuats.Find(id);
                if (hdx == null)
                {
                    return NotFound();
                }
                HoaDonXuatDTO hdxDTO = new HoaDonXuatDTO
                {
                    BanID = hdx.Ban.BanID,
                    ChiNhanhID = hdx.ChiNhanh.ChiNhanhID,
                    DaThanhToan = hdx.DaThanhToan,
                    HinhThucThanhToan = hdx.HinhThucThanhToan,
                    HoaDonXuatID = hdx.HoaDonXuatID,

                    NgayGio = hdx.NgayGio,
                    TongTien = hdx.TongTien,
                    TenKhachHang = hdx.TenKhachHang
                };
                return Ok(hdxDTO);
            }
        }

        /**
          * @api {get} /api/HoaDonXuat/getbyidtable/:id Get HoaDonXuat By Id
          * @apiVersion 0.1.0
          * @apiName GetHoaDonXuatByIdTable
          * @apiGroup HoaDonXuat
          *
          * @apiParam {Number} id BanID unique ID.
          *
          * @apiSuccessExample Success-Response:
          *     HTTP/1.1 200 OK
          *       {
          *            "HoaDonXuatID": 2,
          *            "NgayGio": "2018-11-27T00:00:00",
          *            "HinhThucThanhToan": null,
          *            "TongTien": 0,
          *            "DaThanhToan": false,
          *            "ChiNhanhID": 1,
          *            "BanID": 2,
          *            "TenKhachHang":"Mr.Quynh"
          *       }
          *
          * @apiError HoaDonXuatNotFound The id of the HoaDonXuat was not found.
          *
          * @apiErrorExample Error-Response:
          *     HTTP/1.1 404 Not Found
          *     {
          *       "error": "HoaDonXuatNotFound"
          *     }
          */
        [HttpGet]
        [ActionName("getbyidtable")]
        public IHttpActionResult GetByIdTable(int id)
        {
         

            HoaDonXuatDTO hdxDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                hdxDTO = entities.HoaDonXuats.Where(s => s.BanID == id && s.DaThanhToan == false)
                    .Select(s => new HoaDonXuatDTO()
                    {
                        BanID = s.BanID,
                        ChiNhanhID = s.ChiNhanhID,
                        DaThanhToan = s.DaThanhToan,
                        HinhThucThanhToan = s.HinhThucThanhToan,
                        HoaDonXuatID = s.HoaDonXuatID,
                        NgayGio = s.NgayGio,
                        TongTien = s.TongTien,
                        TenKhachHang = s.TenKhachHang

                    }).FirstOrDefault<HoaDonXuatDTO>();
            }
            if (hdxDTO == null)
            {
                return NotFound();
            }

            return Ok(hdxDTO);
        }

        /**
        * @api {post} api/HoaDonXuat/create Create HoaDonXuat
        * @apiVersion 0.1.0
        * @apiName CreateHoaDonXuat
        * @apiGroup HoaDonXuat
        * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
        * @apiSuccess {String} DaThanhToan  Status of the HoaDonXuat.
        * @apiSuccess {String} HinhThucThanhToan  Description of the HoaDonXuat.
        * @apiSuccess {int} BanID  Id of the Ban.
        * @apiSuccess {int} ChiNhanhID  Id of the ChiNhanh.
        * @apiSuccess {DateTime} NgayGio  Create day of the HoaDonXuat.
        * @apiSuccess {int} TongTien  Total payment the HoaDonXuat.
        * @apiSuccess {string} TenKhachHang Name of the customer
        *
        * @apiSuccessExample Success-Response:
        *     HTTP/1.1 200 OK
        *      "Created Successfully"
        *
        * @apiError HoaDonXuatNotFound The HoaDonXuat was not found.
        *
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 400 Bad Request
        *     {
        *       "error": "The server can not understand the request due to invalid syntax."
        *     }
        */
        [HttpPost]
        [ActionName("create")]
        public IHttpActionResult Create(HoaDonXuatDTO hoadonxuat)
        {
         
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                HoaDonXuat hdx = new HoaDonXuat()
                {
                    HoaDonXuatID = hoadonxuat.HoaDonXuatID,
                    BanID = hoadonxuat.BanID,
                    ChiNhanhID = hoadonxuat.ChiNhanhID,
                    DaThanhToan = hoadonxuat.DaThanhToan,
                    HinhThucThanhToan = hoadonxuat.HinhThucThanhToan,
                    NgayGio = DateTime.Now,
                    TongTien = hoadonxuat.TongTien,
                    TenKhachHang = hoadonxuat.TenKhachHang
                };
                entities.HoaDonXuats.Add(hdx);
                entities.SaveChanges();
                return Ok(hdx);
            }
        }

        /**
         * @api {put} api/HoaDonXuat/update Update HoaDonXuat
         * @apiName UpdateHoaDonXuat
         * @apiGroup HoaDonXuat
         * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
         * @apiSuccess {String} DaThanhToan  Status of the HoaDonXuat.
         * @apiSuccess {String} HinhThucThanhToan  Description of the HoaDonXuat.
         * @apiSuccess {int} BanID  Id of the Ban.
         * @apiSuccess {int} ChiNhanhID  Id of the ChiNhanh.
         * @apiSuccess {DateTime} NgayGio  Create day of the HoaDonXuat.
         * @apiSuccess {int} TongTien  Total payment the HoaDonXuat.
         * @apiSuccess {string} TenKhachHang Name of the customer
         * @apiSuccessExample Success-Response:
         *     HTTP/1.1 200 OK
         *       {
         *            "HoaDonXuatID": 2,
         *            "NgayGio": "2018-11-27T00:00:00",
         *            "HinhThucThanhToan": null,
         *            "TongTien": 0,
         *            "DaThanhToan": false,
         *            "ChiNhanhID": 1,
         *            "BanID": 2,
         *            "TenKhachHang":"Mr.Quynh"
         *       }
         *
         * @apiError HoaDonXuatNotFound The HoaDonXuat was not found.
         *
         * @apiErrorExample Error-Response:
         *     HTTP/1.1 404 Not Found
         *     {
         *       "error": "HoaDonXuatNotFound"
         *     }
         *     HTTP/1.1 400 Bad Request
         *     {
         *       "error": "The server can not understand the request due to invalid syntax."
         *     }
         */
        [HttpPut]
        [ActionName("update")]
        public IHttpActionResult Update(HoaDonXuatDTO hdx)
        {
         
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                HoaDonXuat hd = entities.HoaDonXuats.Find(hdx.HoaDonXuatID);
                if (hdx == null)
                {
                    return NotFound();
                }
                hd.HoaDonXuatID = hdx.HoaDonXuatID;
                hd.BanID = hdx.BanID;
                hd.DaThanhToan = hdx.DaThanhToan;
                hd.HinhThucThanhToan = hdx.HinhThucThanhToan;
                hd.TongTien = hdx.TongTien;
                hd.TenKhachHang = hdx.TenKhachHang;
                entities.SaveChanges();
                return Ok(hdx);
            }
        }

        /**
        * @api {delete} /api/HoaDonXuat/delete/:id Delete HoaDonXuat By Id
        * @apiVersion 0.1.0
        * @apiName DeleteHoaDonXuatById
        * @apiGroup HoaDonXuat
        *
        * @apiParam {Number} id HoaDonXuat Unique ID.

        * @apiSuccessExample Success-Response:
        *     HTTP/1.1 200 OK
        *     "Deleted successfully"
        *
        * @apiError HoaDonXuatNotFound The id of the HoaDonXuat was not found.
        *
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *        "error": "Not Found To Delete"
        *     }
        */
        [HttpDelete]
        [ActionName("delete")]
        public IHttpActionResult Delete(int id)
        {
         
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                HoaDonXuat hdx = entities.HoaDonXuats.Find(id);
                if (hdx == null)
                {
                    return NotFound();
                }
                entities.HoaDonXuats.Remove(hdx);
                entities.SaveChanges();

                return Ok("Deleted successfully");
            }
        }


        /**
        * @api {get} /api/HoaDonXuat/GetHDXbyStt/:stt Get All Product By Satatus stt
        * @apiVersion 0.1.0
        * @apiName GetHDXbyStt
        * @apiGroup HoaDonXuat
        * 
        * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
        * @apiSuccess {String} DaThanhToan  Status of the HoaDonXuat.
        * @apiSuccess {String} HinhThucThanhToan  Description of the HoaDonXuat.
        * @apiSuccess {int} BanID  Id of the Ban.
        * @apiSuccess {int} ChiNhanhID  Id of the ChiNhanh.
        * @apiSuccess {DateTime} NgayGio  Create day of the HoaDonXuat.
        * @apiSuccess {int} TongTien  Total payment the HoaDonXuat.
        * @apiSuccess {string} TenKhachHang Name of the customer
        * 
        * @apiSuccessExample Success-Response:
        *     HTTP/1.1 200 OK
        *     [
    *           {
    *            "HoaDonXuatID": 2,
    *            "NgayGio": "2018-11-27T00:00:00",
    *            "HinhThucThanhToan": null,
    *            "TongTien": 0,
    *            "DaThanhToan": false,
    *            "ChiNhanhID": 1,
    *            "BanID": 2,
    *            "TenKhachHang":"Mr.Quynh"
        *       },
        *       {
    *            "HoaDonXuatID": 2,
    *            "NgayGio": "2018-11-27T00:00:00",
    *            "HinhThucThanhToan": null,
    *            "TongTien": 0,
    *            "DaThanhToan": false,
    *            "ChiNhanhID": 1,
    *            "BanID": 2,
    *            "TenKhachHang":"Mr.Phuc"
        *        }
        *     ]
        *
        * @apiError ProductNotFound The id of the Category was not found.
        *
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "HoaDonXuatNotFound"
        *     }
        */
        [HttpGet]
        [ActionName("getHDXbyStt")]
        public IHttpActionResult getHDXbyStt(bool stt = false)
        {
        
            IList<HoaDonXuatDTO> hoadonxuatDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                hoadonxuatDTO = entities.HoaDonXuats.Include("stt").Where(b => b.DaThanhToan == stt)
                                     .Select(b => new HoaDonXuatDTO()
                                     {
                                         HoaDonXuatID = b.HoaDonXuatID,
                                         NgayGio = b.NgayGio,
                                         HinhThucThanhToan = b.HinhThucThanhToan,
                                         TongTien = b.TongTien,
                                         DaThanhToan = b.DaThanhToan,
                                         TenKhachHang = b.TenKhachHang,
                                         ChiNhanhID = b.ChiNhanhID,
                                         TenBan = b.Ban.TenBan,
                                         BanID = b.BanID
                                     }).ToList<HoaDonXuatDTO>();
            }
            if (hoadonxuatDTO == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(hoadonxuatDTO);
            }
        }
    }
}
