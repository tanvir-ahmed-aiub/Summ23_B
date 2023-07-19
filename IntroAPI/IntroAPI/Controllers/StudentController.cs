using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            var obj = new {
                Msg = "Get method requested"
            
            };
            return Request.CreateResponse(HttpStatusCode.OK,obj);
        }
        public HttpResponseMessage Post() {
            var obj = new
            {
                Msg = "Get method requested"

            };
            return Request.CreateResponse(HttpStatusCode.OK, obj);
        }
    }
}
