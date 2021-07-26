using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    /// <summary>
    /// TopSecret API
    /// </summary>
    public class TopSecretController : ApiController
    {
        /// <summary>
        /// Obtiene el mensaje secreto y la Geolocalización
        /// </summary>
        /// <param name="satelites"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage TopSecret(IEnumerable<Models.Satelites> satelites)
        {
            HttpResponseMessage response = null;
            
            try
            {
                double position1 = 0;
                double position2 = 0;
                double position3 = 0;
                if (ModelState.IsValid)
                {

                    position1 = satelites.FirstOrDefault(x => x.Name == "kenobi").Distance;
                    position2 = satelites.FirstOrDefault(x => x.Name == "skywalker").Distance;
                    position3 = satelites.FirstOrDefault(x => x.Name == "soto").Distance;
                    //obtiene el angulo en un plano
                    double senal1 = Math.Atan2(Math.Sqrt(position1), Math.Sqrt(position2));
                    double senal2 = Math.Atan2(Math.Sqrt(senal1), Math.Sqrt(position3));
                    var modelResponse = new Models.Response()
                    {
                        position = new Models.Response.Position() { X = senal1, Y = senal2 },
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
