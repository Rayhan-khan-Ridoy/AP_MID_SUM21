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
    public class CoachController : ApiController
    {
        [Route("api/Coach/Add")]
        [HttpPost]
        public void AddCoach(AddCoachModel model)
        {

            CoachService.AddCoach(model);
        }
        [Route("api/Coach")]
        [HttpGet]
        public List <CoachModel> GetCoach()
        {
            return CoachService.GetCoach();
        }

        [Route("api/Coach/{id}")]
        [HttpGet]
        public CoachInfoModel GetCoach(int id)
        {
            return CoachService.GetCoach(id);
        }
        [Route("api/CoachEdit/{id}")]
        [HttpPost]
        public void CoachEdit(CoachInfoModel obj)
        {
            CoachService.CoachEdit(obj);
        }
        [Route("api/Coach/Delete/{id}")]
        [HttpGet]
        public void CoachDelete(int id)
        {

            CoachService.CoachDelete(id);
        }
        [Route("api/Coach/Details")]
        [HttpGet]
        public List<CoachInfoModel> GetCoachDetails()
        {

            return CoachService.GetCoachDetails();
        }

    }
}
