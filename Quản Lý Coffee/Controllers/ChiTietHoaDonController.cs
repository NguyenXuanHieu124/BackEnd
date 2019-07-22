using Quản_Lý_Coffee.Models;
using Quản_Lý_Coffee.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Quản_Lý_Coffee.Controllers
{
    public class ChiTietHoaDonController : ApiController
    {
        private QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext();
        /**
 * @api {post} api/ChiTietHoaDon/CreateCTHD Create ChiTietHoaDOn
 * @apiName CreateChiTietHonDon
 * @apiGroup ChiTietHoaDon
 * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
 * @apiSuccess {int} SanPhamID  Id of the SanPham.
 * @apiSuccess {int} SoLuong  Count Number of the SanPham.
 *
 * @apiSuccessExample Success-Response:
 *     HTTP/1.1 200 OK
 *     {
 *        "HoaDonXuatID":"1",
 *        "SanPhamID":"1",
 *        "SoLuong":"1"
 *     }
 *
 * @apiError ChiTietHoaDonNotFound The ChiTietHoaDon was not found.
 *
 * @apiErrorExample Error-Response:
 *     HTTP/1.1 400 Bad Request
 *     {
 *       "error": "The server can not understand the request due to invalid syntax."
 *     }
 */
        [HttpPost]
        [ActionName("CreateCTHD")]
        public IHttpActionResult CreateCTHD(ChiTietHoaDonDTO CTHDDTO)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            {
                ChiTietHoaDon chitiethoadon = new ChiTietHoaDon()
                {
                    SanPhamID = CTHDDTO.SanPhamID,
                    HoaDonXuatID = CTHDDTO.HoaDonXuatID,
                    SoLuong = CTHDDTO.SoLuong
                };
                entities.ChiTietHoaDons.Add(chitiethoadon);
                entities.SaveChanges();
                return Ok(CTHDDTO);
            }
        }


        /**
       * @api {get} api/ChiTietHoaDon/GetChiTietHoaDons Get All ChiTietHoaDon
       * @apiName GetChiTietHoaDons
       * @apiGroup ChiTietHoaDon
       *
       *
       * @apiSuccessExample Success-Response:
       *     HTTP/1.1 200 OK
       *     [
       *       {
       *        "HoaDonXuatID":"1",
       *        "SanPhamID":"1",
       *        "SoLuong":"1"
       *       },
       *       {
       *        "HoaDonXuatID":"2",
       *        "SanPhamID":"2",
       *        "SoLuong":"2"
       *       }
       *     ]
       *     
       *
       * @apiError ChiTietHoaDonNotFound The id of the HoaDonXuat was not found.
       *
       * @apiErrorExample Error-Response:
       *     HTTP/1.1 404 Not Found
       *     {
     *       "error": "NotFound"
     *     }
     */

        [HttpGet]
        [ActionName("GetChiTietHoaDons")]
        public IHttpActionResult GetChiTietHoaDons()
        {
            IList<ChiTietHoaDonDTO> chitiethoadonDTO = null;
            {
                chitiethoadonDTO = entities.ChiTietHoaDons
                            .Select(b => new ChiTietHoaDonDTO()
                            {
                                SanPhamID = b.SanPhamID,
                                HoaDonXuatID = b.HoaDonXuatID,
                                SoLuong = b.SoLuong
                            }).ToList<ChiTietHoaDonDTO>();
            }
            if (chitiethoadonDTO.Count == 0)
            {
                return NotFound();

            }
            else
            {
                return Ok(chitiethoadonDTO);
            }
        }

        /**
          * @api {get} /api/ChiTietHoaDon/GetChiTietHoaDonByid/:id Get ChiTietHoaDon By HDXId
          * @apiVersion 0.1.0
          * @apiName GetChiTietHoaDonByTableId
          * @apiGroup ChiTietHoaDon
          *
          * @apiParam {Number} HDXId ChiTietHoaDon ID.
          *
          * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
          * @apiSuccess {int} SanPhamID  Id of the SanPham.
          * @apiSuccess {int} SoLuong  Count Number of the SanPham.
          *
          * @apiSuccessExample Success-Response:
          *     HTTP/1.1 200 OK
          *      {
          *        "HoaDonXuatID":"1",
          *        "SanPhamID":"1",
          *        "SoLuong":"1"
          *       },
          *
          * @apiError ChiTietHoaDonNotFound The id of the HoaDonXuat was not found.
          *
          * @apiErrorExample Error-Response:
          *     HTTP/1.1 404 Not Found
          *     {
          *       "error": "ChiTietHoaDonNotFound"
          *     }
          */
        [HttpGet]
        [ActionName("GetChiTietHoaDonByHDXId")]
        public IHttpActionResult GetChiTietHoaDonByid(int id)
        {
            {
                IList<ChiTietHoaDonDTO> chitiethoadonDTO = null;
                {
                    chitiethoadonDTO = entities.ChiTietHoaDons.Where(x => x.HoaDonXuatID == id)
                                .Select(b => new ChiTietHoaDonDTO()
                                {
                                    SanPhamID = b.SanPhamID,
                                    HoaDonXuatID = b.HoaDonXuatID,
                                    SoLuong = b.SoLuong,
                                    TenSanPham = b.SanPham.TenSP
                                }).ToList<ChiTietHoaDonDTO>();
                }
                if (chitiethoadonDTO.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(chitiethoadonDTO);
                }
            }
        }


        /**
           * @api {get} /api/ChiTietHoaDon/GetChiTietHoaDonByid/:id Get ChiTietHoaDon By HDXId
           * @apiVersion 0.1.0
           * @apiName GetChiTietHoaDonByTableId
           * @apiGroup ChiTietHoaDon
           *
           * @apiParam {Number} HDXId ChiTietHoaDon ID.
           *
           * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
           * @apiSuccess {int} SanPhamID  Id of the SanPham.
           * @apiSuccess {int} SoLuong  Count Number of the SanPham.
           *
           * @apiSuccessExample Success-Response:
           *     HTTP/1.1 200 OK
           *      {
           *        "HoaDonXuatID":"1",
           *        "SanPhamID":"1",
           *        "SoLuong":"1"
           *       },
           *
           * @apiError ChiTietHoaDonNotFound The id of the HoaDonXuat was not found.
           *
           * @apiErrorExample Error-Response:
           *     HTTP/1.1 404 Not Found
           *     {
           *       "error": "ChiTietHoaDonNotFound"
           *     }
           */
        [HttpGet]
        [ActionName("GetChiTietHoaDonByHDXIdSPId")]
        public IHttpActionResult GetChiTietHoaDonByHDXSPId(int idHDX, int idSP)
        {
            {
                IList<ChiTietHoaDonDTO> chitiethoadonDTO = null;
                {
                    chitiethoadonDTO = entities.ChiTietHoaDons.Where(x => x.HoaDonXuatID == idHDX && x.SanPhamID == idSP)
                                .Select(b => new ChiTietHoaDonDTO()
                                {
                                    SanPhamID = b.SanPhamID,
                                    HoaDonXuatID = b.HoaDonXuatID,
                                    SoLuong = b.SoLuong,
                                    TenSanPham = b.SanPham.TenSP
                                }).ToList<ChiTietHoaDonDTO>();
                }
                if (chitiethoadonDTO.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok();
                }
            }
        }


        /**
         * @api {put} api/ChiTietHoaDon/UpdateCTHD Update ChiTietHoaDon
         * @apiName UpdateChiTietHoaDon
         * @apiGroup ChiTietHoaDon
         * @apiSuccess {int} HoaDonXuatID Id of the HoaDonXuat.
         * @apiSuccess {int} SanPhamID  Id of the SanPham.
         * @apiSuccess {int} SoLuong  Count Number of the SanPham.
         *
         * @apiSuccessExample Success-Response:
         *     HTTP/1.1 200 OK
         *        {
          *        "HoaDonXuatID":"1",
          *        "SanPhamID":"1",
          *        "SoLuong":"1"
          *       },
         *
         * @apiError ChiTietHoaDonNotFound The ChiTietHoaDon was not found.
         *
         * @apiErrorExample Error-Response:
         *     HTTP/1.1 404 Not Found
         *     {
         *       "error": "ChiTietHoaDonNotFound"
         *     }
         *     HTTP/1.1 400 Bad Request
         *     {
         *       "error": "The server can not understand the request due to invalid syntax."
         *     }
         */
        [HttpPut]
        [ActionName("UpdateCTHD")]
        public IHttpActionResult UpdateCTHD(ChiTietHoaDonDTO chitiethoadonDTO)
        {
            var chitiet = entities.ChiTietHoaDons.Include("HoaDonXuat")
                .Where(s => s.HoaDonXuatID == chitiethoadonDTO.HoaDonXuatID && s.SanPhamID == chitiethoadonDTO.SanPhamID)
                .FirstOrDefault();
            if (chitiet == null)
            {
                return NotFound();
            }
            chitiet.HoaDonXuatID = chitiethoadonDTO.HoaDonXuatID;
            chitiet.SanPhamID = chitiethoadonDTO.SanPhamID;
            chitiet.SoLuong = chitiethoadonDTO.SoLuong;
            entities.SaveChanges();
            return Ok();
        }

        /**
           * @api {delete} /api/ChiTietHoaDon/DeleteCTHD/:id Delete ChiTietHoaDon By Id
           * @apiVersion 0.1.0
           * @apiName ChiTietHoaDonById
           * @apiGroup ChiTietHoaDon
           *
           * @apiParam {Number} id ChiTietHoaDon Unique ID.

           * @apiSuccessExample Success-Response:
           *     HTTP/1.1 200 OK
           *     "Deleted successfully"
           *
           * @apiError ChiTietHoaDonNotFound The id of the ChiTietHoaDon was not found.
           *
           * @apiErrorExample Error-Response:
           *     HTTP/1.1 404 Not Found
           *     {
           *        "error": "Not Found To Delete"
           *     }
           */
        [HttpDelete]
        [ActionName("DeleteCTHD")]
        public IHttpActionResult DeleteCTHD(int id)
        {

            {
                ChiTietHoaDon chitiethoadon = entities.ChiTietHoaDons.Find(id);
                if (chitiethoadon == null)
                {
                    return NotFound();
                }
                entities.ChiTietHoaDons.Remove(chitiethoadon);
                entities.SaveChanges();

                return Ok("Deleted successfully");
            }
        }
    }
}
