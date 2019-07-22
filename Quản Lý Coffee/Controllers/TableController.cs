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
    [Authorize]
    public class TableController : ApiController
    {
        
        [HttpGet]
        [ActionName("GetBans")]
        public IHttpActionResult GetBans()
        {
            IList<TableDTO> tableDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                tableDTO = entities.Bans.Include("BanID")
                            .Select(b => new TableDTO()
                            {
                                BanID = b.BanID,
                                TenBan = b.TenBan,
                                Status = b.Status
                            }).ToList<TableDTO>();
            }
            if (tableDTO.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(tableDTO);
            }
        }

        [HttpGet]
        [ActionName("GetBanStatus")]
        public IHttpActionResult GetBansByStatus(int status)
        {
            IList<TableDTO> tableDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                if (status == 1)
                {
                    tableDTO = entities.Bans.Include("BanID").Where(b => b.Status != status)
                           .Select(b => new TableDTO()
                           {
                               BanID = b.BanID,
                               TenBan = b.TenBan,
                               Status = b.Status
                           }).ToList<TableDTO>();
                }

            }
            if (tableDTO.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(tableDTO);
            }
        }

        [HttpGet]
        [ActionName("GetBansOrder")]
        public IHttpActionResult GetBansOrder(int status)
        {
            IList<TableDTO> tableDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                if (status == 1)
                {
                    tableDTO = entities.Bans.Include("BanID").Where(b => b.Status == status)
                           .Select(b => new TableDTO()
                           {
                               BanID = b.BanID,
                               TenBan = b.TenBan,
                               Status = b.Status
                           }).ToList<TableDTO>();
                }

            }
            if (tableDTO.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(tableDTO);
            }
        }

        [HttpGet]
        [ActionName("gettable")]
        public IHttpActionResult GetTableById(int id)
        {
            TableDTO tableDTO = null;
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                tableDTO = entities.Bans.Include("BanID").Where(b => b.BanID == id)
                                     .Select(b => new TableDTO()
                                     {
                                         BanID = b.BanID,
                                         TenBan = b.TenBan,
                                         Status = b.Status
                                     }).FirstOrDefault<TableDTO>();
            }
            if (tableDTO == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(tableDTO);
            }
        }

        [HttpPut]
        [ActionName("updatetable")]
        public IHttpActionResult UpdateTable(TableDTO tb)
        {
            using (QuanLyCoffeeDbContext entities = new QuanLyCoffeeDbContext())
            {
                Ban ban = entities.Bans.Find(tb.BanID);
                if (ban == null)
                {
                    return NotFound();
                }
                ban.Status = tb.Status;
                entities.SaveChanges();
                return Ok();
            }

        }
    }
}
