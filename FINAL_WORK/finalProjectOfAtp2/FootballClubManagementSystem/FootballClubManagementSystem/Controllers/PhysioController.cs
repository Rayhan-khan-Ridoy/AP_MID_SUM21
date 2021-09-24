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
    public class PhysioController : ApiController
    {
        [Route("api/Physio/Add")]
        [HttpPost]
        public void AddPhysio(AddPhysioModel model)
        {

            PhysioService.AddPhysio(model);
        }
        [Route("api/Physio")]
        [HttpGet]
        public List<PhysioInfoModel> GetPhysio()
        {
            return PhysioService.GetPhysio();
        }

        [Route("api/Physio/{id}")]
        [HttpGet]
        public PhysioInfoModel GetPhysioInfo(int id)
        {
            return PhysioService.GetPhysioInfo(id);
        }

        [Route("api/Physio/Edit/{id}")]
        [HttpPost]
        public void PhysioEdit(PhysioModel obj)
        {
            PhysioService.PhysioEdit(obj);
        }
        [Route("api/Physio/Delete/{id}")]
        [HttpGet]
        public void PhysioDelete(int id)
        {

            PhysioService.PhysioDelete(id);
        }
        [Route("api/Physio/Details")]
        [HttpGet]
        public List<PhysioInfoModel> GetPhysioDetails()
        {

            return PhysioService.GetPhysioDetails();
        }
    }
}
