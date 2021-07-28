using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;

namespace _4_tier_assignment.Controllers
{
    public class DEPARTMENTController : ApiController
    {
        

        [Route("api/DEPARTMENT/NAMES")]
        [HttpGet]

        public List<string> GetNAMES()
        {
            return DEPARTMENT_SERVICE.GetDEPARTMENTNAMES();
        }

        [Route("api/DEPARTMENT/GetAll")]
        [HttpGet]
        public List<DEPARTMENTMODEL> GetAllDepartments()
        {
            return DEPARTMENT_SERVICE.GetDEPARTMENT();
        }


        [Route("api/DEPARTMENT/Add")]
        [HttpPost]
        public void Add(DEPARTMENTMODEL dept)
        {
          
          DEPARTMENT_SERVICE.AddDEPARTMENT(dept);
        }
    }
}
