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
    public class LoginController : ApiController
    {
        [Route("api/Login/Players/{id}/{pass}")]
        [HttpPost]
        public bool loginPlayer(int id, string pass)
        {
            return LoginService.loginPlayer(id, pass);
        }

        [Route("api/Login/Admin/{id}/{pass}")]
        [HttpPost]
        public bool loginAdmin(int id, string pass)
        {
            return LoginService.loginAdmin(id, pass);
        }

        [Route("api/Login/Coach/{id}/{pass}")]
        [HttpPost]
        public bool loginCoach(int id, string pass)
        {
            return LoginService.loginCoach(id, pass);
        }

        [Route("api/Login/Physio/{id}/{pass}")]
        [HttpPost]
        public bool loginPhysio(int id, string pass)
        {
            return LoginService.loginPhysio(id, pass);
        }

        [Route("api/Login/Player")]
        [HttpPost]
        public bool PlayerLogin(LogInModel obj)
        {
            return LoginService.PlayerLogin(obj);
        }

        [Route("api/Login/Admin")]
        [HttpPost]
        public bool AdminLogin(LogInModel obj)
        {
            return LoginService.AdminLogin(obj);
        }


        [Route("api/Login/Coach")]
        [HttpPost]
        public bool CoachLogin(LogInModel obj)
        {
            return LoginService.CoachLogin(obj);
        }


        [Route("api/Login/Physio")]
        [HttpPost]
        public bool PhysioLogin(LogInModel obj)
        {
            return LoginService.PhysioLogin(obj);
        }


    }
}
