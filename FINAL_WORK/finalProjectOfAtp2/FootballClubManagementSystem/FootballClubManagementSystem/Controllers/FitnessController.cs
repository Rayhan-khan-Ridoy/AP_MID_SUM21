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
    public class FitnessController : ApiController
    {
        [Route("api/Fitness/All")]
        [HttpGet]
        public List<FitnessDetailsModel> GetFitnessDetails() {

            return FitnessService.GetFitnessDetails();
        }

        [Route("api/Fitness/Add")]
        [HttpPost]
        public void AddFitness(AddFitnessModel model)
        {

            FitnessService.AddFitness(model);
        }

        [Route("api/Fitness/{id}")]
        [HttpGet]
        public FitnessModel GetFitness(int id)
        {
            return FitnessService.GetFitness(id);
        }

        [Route("api/FitnessEdit/{id}")]
        [HttpPost]
        public void FitnessEdit(EditFitnessModel obj)
        {
            FitnessService.FitnessEdit(obj);
        }

        [Route("api/Fitness/Delete/{id}")]
        [HttpGet]
        public void FitnessDelete(int id)
        {

            FitnessService.FitnessDelete(id);
        }
    }
}
