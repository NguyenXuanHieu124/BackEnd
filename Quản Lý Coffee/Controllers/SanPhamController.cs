using Quản_Lý_Coffee.Models;
using Quản_Lý_Coffee.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Quản_Lý_Coffee.Controllers
{
    public class SanPhamController : ApiController
    {
        /**
  * @api {get} api/SanPham/GetSanPhams Get All Product
  * @apiName GetAllProduct
  * @apiGroup Product
  *
  *
  * @apiSuccessExample Success-Response:
  *     HTTP/1.1 200 OK
  *     [
  *       {
  *       "SanPhamID":"1",
  *       "TenSP":"Cafe sữa",
  *       "Gia":"19000",
  *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
  *       Mauris euismod fringilla interdum.",
  *       "LinkImage":"http://localhost:8088/Image/tenanh"
  *       },
  *       {
  *       "SanPhamID":"2",
  *       "TenSP":"Cafe Đá",
  *       "Gia":"11000",
  *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
  *       Mauris euismod fringilla interdum.",
  *       "LinkImage":"http://localhost:8088/Image/tenanh"
  *       }
  *     ]
  *     
  *
  * @apiError ProductNotFound The id of the Product was not found.
  *
  * @apiErrorExample Error-Response:
  *     HTTP/1.1 404 Not Found
  *     {
  *       "error": "NotFound"
  *     }
  */
        [HttpGet]
        [ActionName("GetSanPhams")]
        public IHttpActionResult GetSanPham()
        {
     
            IList<SanPhamDTO> productDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                productDTO = entities.SanPhams.Include("SanPhamID")
                            .Select(b => new SanPhamDTO()
                            {
                                SanPhamID = b.SanPhamID,
                                TenSP = b.TenSP,
                                Gia = b.Gia,
                                MoTa = b.MoTa,
                                LinkImage = b.LinkImage
                            }).ToList<SanPhamDTO>();
            }
            if (productDTO.Count == 0)
            {
                return NotFound();

            }
            else
            {
                return Ok(productDTO);
            }
        }

        /**
            * @api {get} /api/SanPham/getsanphambyid/:id Get Product By Id
            * @apiVersion 0.1.0
            * @apiName GetProduct
            * @apiGroup Product
            *
            * @apiParam {Number} id Product unique ID.
            *
            * @apiSuccess {int} SanPhamID Id of the Product.
            * @apiSuccess {String} TenSP  Name of the Product.
            * @apiSuccess {String} MoTa  Description of the Product.
            * @apiSuccess {int} Gia  Price of the Product.
            * @apiSuccess {String} LinkImage  Link image of the Product.
            *
            * @apiSuccessExample Success-Response:
            *     HTTP/1.1 200 OK
            *       {
            *       "SanPhamID":"1",
            *       "TenSP":"Cafe sữa",
            *       "Gia":"19000",
            *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
            *        Mauris euismod fringilla interdum.",
            *       "LinkImage":"http://localhost:8088/Image/tenanh"
            *       },
            *
            * @apiError ProductNotFound The id of the Category was not found.
            *
            * @apiErrorExample Error-Response:
            *     HTTP/1.1 404 Not Found
            *     {
            *       "error": "ProductNotFound"
            *     }
            */
        [HttpGet]
        [ActionName("getsanphambyid")]
        public IHttpActionResult GetSanPhamById(int id)
        {
           
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                SanPham sanPham = entities.SanPhams.Find(id);
                if (sanPham == null)
                {
                    return NotFound();
                }
                SanPhamDTO sanPhamDTO = new SanPhamDTO
                {
                    SanPhamID = sanPham.SanPhamID,
                    TenSP = sanPham.TenSP,
                    Gia = sanPham.Gia,
                    MoTa = sanPham.MoTa,
                    LinkImage = sanPham.LinkImage
                };
                return Ok(sanPhamDTO);
            }

        }

        /**
           * @api {get} /api/SanPham/getsanphambycategory/:id Get All Product By Category Id
           * @apiVersion 0.1.0
           * @apiName GetProductByCategoryId
           * @apiGroup Product
           *
           * @apiParam {Number} id Category ID.
           *
           * @apiSuccess {int} SanPhamID Id of the Product.
           * @apiSuccess {String} TenSP  Name of the Product.
           * @apiSuccess {String} MoTa  Description of the Product.
           * @apiSuccess {int} Gia  Price of the Product.
           * @apiSuccess {String} LinkImage  Link image of the Product.
           *
           * @apiSuccessExample Success-Response:
           *     HTTP/1.1 200 OK
           *     [
           *       {
           *       "SanPhamID":"1",
           *       "TenSP":"Cafe sữa",
           *       "Gia":"19000",
           *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
           *       Mauris euismod fringilla interdum.",
           *       "LinkImage":"http://localhost:8088/Image/tenanh"
           *       },
           *       {
           *       "SanPhamID":"2",
           *       "TenSP":"Cafe Đá",
           *       "Gia":"11000",
           *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
           *       Mauris euismod fringilla interdum.",
           *       "LinkImage":"http://localhost:8088/Image/tenanh"
           *       }
           *     ]
           *
           * @apiError ProductNotFound The id of the Category was not found.
           *
           * @apiErrorExample Error-Response:
           *     HTTP/1.1 404 Not Found
           *     {
           *       "error": "ProductNotFound"
           *     }
           */
        [HttpGet]
        [ActionName("getsanphambycategory")]
        public IHttpActionResult GetSanPhamByCategory(int id)
        {
           
            IList<SanPhamDTO> sanPhamDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                sanPhamDTO = entities.SanPhams.Include("SanPhamID").Where(b => b.LoaiSP.LoaiSPID == id)
                                     .Select(b => new SanPhamDTO()
                                     {
                                         SanPhamID = b.SanPhamID,
                                         TenSP = b.TenSP,
                                         Gia = b.Gia,
                                         MoTa = b.MoTa,
                                         LinkImage = b.LinkImage,
                                         LoaiSPID = b.LoaiSP.LoaiSPID
                                     }).ToList<SanPhamDTO>();
            }
            if (sanPhamDTO == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(sanPhamDTO);
            }
        }

        /**
        * @api {put} api/SanPham/updatesanpham Update Product
        * @apiName UpdateProduct
        * @apiGroup Product
        * @apiSuccess {int} SanPhamID Id of the Product.
        * @apiSuccess {String} TenSP  Name of the Product.
        * @apiSuccess {String} MoTa  Description of the Product.
        * @apiSuccess {int} Gia  Price of the Product.
        * @apiSuccess {String} LinkImage  Link image of the Product.
        *
        * @apiSuccessExample Success-Response:
        *     HTTP/1.1 200 OK
        *       {
        *       "SanPhamID":"1",
        *       "TenSP":"Cafe sữa",
        *       "Gia":"19000",
        *       "MoTa":"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
        *        Mauris euismod fringilla interdum.",
        *       "LinkImage":"http://localhost:8088/Image/tenanh"
        *       },
        *
        * @apiError ProductNotFound The Product was not found.
        *
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 404 Not Found
        *     {
        *       "error": "ProductNotFound"
        *     }
        *     HTTP/1.1 400 Bad Request
        *     {
        *       "error": "The server can not understand the request due to invalid syntax."
        *     }
        */
        [HttpPut]
        [ActionName("updatesanpham")]
        public IHttpActionResult PutSanPham(SanPhamDTO sanPham)
        {
        
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                var sanpham = entities.SanPhams.Where(s => s.SanPhamID == sanPham.SanPhamID)
                    .FirstOrDefault<SanPham>();
                if (sanpham != null)
                {
                    sanpham.TenSP = sanPham.TenSP;
                    sanpham.MoTa = sanPham.MoTa;
                    sanpham.LinkImage = sanPham.LinkImage;
                    sanpham.Gia = sanPham.Gia;
                    sanpham.LoaiSP.LoaiSPID = sanPham.LoaiSPID;

                    entities.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }

        /**
        * @api {put} api/SanPham/createsanpham Create Product
        * @apiName CreateProduct
        * @apiGroup Product
        * @apiSuccess {int} SanPhamID Id of the Product.
        * @apiSuccess {String} TenSP  Name of the Product.
        * @apiSuccess {String} MoTa  Description of the Product.
        * @apiSuccess {int} Gia  Price of the Product.
        * @apiSuccess {int} LoaiSPID  Id of the LoaiSP.
        * @apiSuccess {String} LinkImage  Link image of the Product.
        *
        * @apiSuccessExample Success-Response:
        *     HTTP/1.1 200 OK
        *      "Created Successfully"
        *
        * @apiError ProductNotFound The Product was not found.
        *
        * @apiErrorExample Error-Response:
        *     HTTP/1.1 400 Bad Request
        *     {
        *       "error": "The server can not understand the request due to invalid syntax."
        *     }
        */
        [HttpPost]
        [ActionName("createsanpham")]
        public IHttpActionResult CreateSanPham(SanPhamDTO sanPham)
        {
         
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                entities.SanPhams.Add(new SanPham()
                {
                    TenSP = sanPham.TenSP,
                    MoTa = sanPham.MoTa,
                    LinkImage = sanPham.LinkImage,
                    LoaiSPID = sanPham.LoaiSPID,
                    Gia = sanPham.Gia,
                });
                entities.SaveChanges();
            }
            return Ok("Created Successfully");
        }

        /**
         * @api {get} /api/SanPham/deletesanpham/:id Delete Product By Id
         * @apiVersion 0.1.0
         * @apiName DeleteProductById
         * @apiGroup Product
         *
         * @apiParam {Number} id Product Unique ID.

         * @apiSuccessExample Success-Response:
         *     HTTP/1.1 200 OK
         *     "Deleted successfully"
         *
         * @apiError ProductNotFound The id of the Product was not found.
         *
         * @apiErrorExample Error-Response:
         *     HTTP/1.1 404 Not Found
         *     {
         *        "error": "Not Found To Delete"
         *     }
         */
        [HttpDelete]
        [ActionName("deletesanpham")]
        public IHttpActionResult DeleteSanPham(int id)
        {
         

            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                SanPham sanPham = entities.SanPhams.Find(id);
                if (sanPham == null)
                {
                    return NotFound();
                }
                entities.SanPhams.Remove(sanPham);
                entities.SaveChanges();

                return Ok("Deleted successfully");
            }
        }
    }

}
