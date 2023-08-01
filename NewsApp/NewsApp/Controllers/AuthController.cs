using BLL.Services;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApp.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel data) {
            var token = AuthService.Login(data.Username, data.Password);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else { 
                return Request.CreateResponse(HttpStatusCode.NotFound,new { Msg="User not found"});
            }
            
            return null;
        }
    }
}
