using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApp.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = NewsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/news/date/{date}")]
        public HttpResponseMessage Get(DateTime date) {
            try
            {
                var data = NewsService.Get(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/news/cat/{cat}")]
        public HttpResponseMessage Get(string cat)
        {
            try
            {
                var data = NewsService.Get(cat);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/news/cat/{cat}/date/{date}")]
        public HttpResponseMessage Get(string cat, DateTime date)
        {
            try
            {
                var data = NewsService.Get(cat, date);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
