using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Quản_Lý_Coffee.Controllers
{
    public class UploadFileController : ApiController
    {
        public HttpResponseMessage Post()

        {
            HttpResponseMessage result = null;

            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                string avatarName = "";
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];

                    var filePath = HttpContext.Current.Server.MapPath("~/Avatars/" + postedFile.FileName);

                    postedFile.SaveAs(filePath);

                    docfiles.Add(filePath);
                    avatarName = postedFile.FileName;
                }
                result = Request.CreateResponse(HttpStatusCode.Created, avatarName);
            }

            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }
    }
}
