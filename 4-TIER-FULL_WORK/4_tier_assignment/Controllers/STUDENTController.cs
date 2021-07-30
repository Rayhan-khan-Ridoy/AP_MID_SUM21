using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _4_tier_web_api.Controllers
{
    public class STUDENTController : ApiController
    {
        [Route("api/Student/GetAll")]
        public List<STUDENTMODEL> GetAllStudents()
        {
            return STUDENT_SERVICE.GetAllStudents();
        }
        [Route("api/Student/{id}")]
        public STUDENTMODEL GetStudent(int id)
        {
            return STUDENT_SERVICE.GetStudent(id);
        }
        [Route("api/Student/Add")]
        public void AddStudent(STUDENTMODEL model)
        {
            STUDENT_SERVICE.AddStudent(model);
        }
        [Route("api/Student/Names")]
        public List<string> GetStudentNames()
        {
            return STUDENT_SERVICE.GetStudentNames();
        }
    }
}
