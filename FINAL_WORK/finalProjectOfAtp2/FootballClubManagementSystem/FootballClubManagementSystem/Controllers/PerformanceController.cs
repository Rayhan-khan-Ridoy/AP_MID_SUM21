using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballClubManagementSystem.Controllers
{
    public class PerformanceController : ApiController
    {
        [Route ("api/Performance/All")]
        [HttpGet]
        public List <PerformanceModel> GetAll()
        {
            return PerformanceService.GetAll();

        }

        [Route("api/Performance/Add")]
        [HttpPost]
        public void AddPerformance(AddPerformanceModel model) {

            PerformanceService.AddPerformance(model);
        }

        [Route("api/Performance/{id}")]
        [HttpGet]
        public PerformanceModel GetPerformance(int id)
        {
            return PerformanceService.GetPerformance(id);
        }

        [Route("api/PerformanceEdit/{id}")]
        [HttpPost]
        public void PerformanceEdit(EditPerformanceModel obj)
        {
            PerformanceService.PerformanceEdit(obj);
        }
        [Route("api/Performance/Details/{id}")]
        [HttpGet]
        public PerformanceDetailsModel GetPerformanceIndividual(int id)
        {
            return PerformanceService.GetPerformanceIndividual(id);
        }

        [Route("api/Performance/Delete/{id}")]
        [HttpGet]
        public void PerformanceDelete(int id)
        {

            PerformanceService.PerformanceDelete(id);
        }

        [Route("api/Performance/Details")]
        [HttpGet]
        public List<PerformanceDetailsModel> GetPerformanceDetails()
        {

            return PerformanceService.GetPerformanceDetails();
        }
    }
}
