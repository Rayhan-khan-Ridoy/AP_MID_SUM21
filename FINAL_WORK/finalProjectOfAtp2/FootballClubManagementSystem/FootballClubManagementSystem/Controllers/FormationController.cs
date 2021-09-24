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
    public class FormationController : ApiController
    {

        [Route("api/Formation/Add")]
        [HttpPost]
        public void AddFormation(FormationModel model)
        {
            FormationService.AddFormation(model);
        }
        [Route("api/Formation")]
        [HttpGet]
        public List<FormationModel> GetFormation()
        {
            return FormationService.GetFormation();
        }

        [Route("api/Formation/{id}")]
        [HttpGet]
        public FormationModel GetFormationDetails(int id)
        {
            return FormationService.GetFormationDetails(id);
        }
        [Route("api/Formation/Edit/{id}")]
        [HttpPost]
        public void FormationEdit(FormationModel obj)
        {
            FormationService.FormationEdit(obj);
        }
        [Route("api/Formation/Delete/{id}")]
        [HttpGet]
        public void FormationDelete(int id)
        {

            FormationService.FormationDelete(id);
        }
        
    }
}
