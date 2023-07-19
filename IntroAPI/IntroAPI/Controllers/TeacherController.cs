using IntroAPI.EF;
using IntroAPI.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("api/teacher/all")]
        public HttpResponseMessage All() {
            var db = new UMSContext();
            var data = db.Teachers.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/teacher/{id}")]
        public HttpResponseMessage Get(int id) { 
            var db = new UMSContext();
            var data = db.Teachers.Find(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/teacher/{name}")]
        public HttpResponseMessage GetByName(string name) {
            var db = new UMSContext();
            var data = (from t in db.Teachers
                        where t.Name.Contains(name)
                        select t).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/teacher/create")]
        public HttpResponseMessage Create(Teacher obj) {
            var db = new UMSContext();
            try
            {
                
                db.Teachers.Add(obj);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception ex) {
               return Request.CreateResponse(HttpStatusCode.InternalServerError,ex.Message);
            }
        }
        [HttpPost]
        [Route("api/teacher/update")]
        public HttpResponseMessage Update(Teacher upda) {
            var db = new UMSContext();
            var exteacher = db.Teachers.Find(upda.Id);
            db.Entry(exteacher).CurrentValues.SetValues(upda);//dont use always
            //db.Teacher.Remove(exteacher) //for removal
            try
            {
              
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
