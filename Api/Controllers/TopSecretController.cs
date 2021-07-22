using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class TopSecretController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage TopSecret(IEnumerable<Models.Satelites> satelites)
        {
            HttpResponseMessage response = null;
            
            try
            {
                if (ModelState.IsValid)
                {
                    var modelResponse = new Models.Response()
                    {
                        position = new Models.Response.Position() { X = -100.00, Y = 75.5 },
                        Message = "este es un mensaje secreto"
                    };
                    response = Request.CreateResponse(HttpStatusCode.OK, modelResponse);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }
            
            return response;
        }
    }
}
