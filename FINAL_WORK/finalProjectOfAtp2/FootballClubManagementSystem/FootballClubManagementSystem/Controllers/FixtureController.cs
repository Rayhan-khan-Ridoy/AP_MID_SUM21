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
    public class FixtureController : ApiController
    {
        [Route("api/Fixture/Add")]
        [HttpPost]
        public void AddFixture(AddFixtureModel model)
        {

            FixtureService.AddFixture(model);
        }
        [Route("api/Fixture/All")]
        [HttpGet]
        public List<FixtureModel> GetFixture()
        {
            return FixtureService.GetFixture();
        }

        [Route("api/Fixture/{id}")]
        [HttpGet]
        public FixtureModel GetFixtures(int id)
        {
            return FixtureService.GetFixtures(id);
        }


        [Route("api/Fixture/Edit/{id}")]
        [HttpPost]
        public void FixtureEdit(FixtureModel obj)
        {
            FixtureService.FixtureEdit(obj);
        }
        [Route("api/Fixture/Delete/{id}")]
        [HttpGet]
        public void FixtureDelete(int id)
        {

            FixtureService.FixtureDelete(id);
        }
    }
}
