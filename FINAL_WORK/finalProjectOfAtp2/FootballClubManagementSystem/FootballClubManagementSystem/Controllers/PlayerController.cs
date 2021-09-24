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
    
    public class PlayerController : ApiController
    {
        [Route("api/Player/Add")]
        [HttpPost]
        public void AddPlayer(AddPlayerModel model)
        {
            PlayerService.AddPlayer(model);
        }

        [Route("api/Players/All")]
        [HttpGet]
        public List<PlayerModel> GetAllPlayers() {

                return PlayerService.GetAllPlayers();
        }
        [Route("api/Player/{id}")]
        [HttpGet]
        public PlayerModel GetPlayer(int id)
        {
            return PlayerService.GetPlayer(id);
        }

        [Route("api/PlayerEdit/{id}")]
        [HttpPost]
        public void PlayerEdit(EditPlayerModel obj)
        {
            PlayerService.PlayerEdit(obj);
        }

        [Route("api/Player/Delete/{id}")]
        [HttpGet]
        public void PlayerDelete(int id) {

            PlayerService.PlayerDelete(id);
        }
        [Route("api/Player/Wingers")]
        [HttpGet]
        public List<PlayerModel> GetWinger() {

            return PlayerService.GetWinger();
        }
        [Route("api/Player/CF")]
        [HttpGet]
        public List<PlayerModel> GetCF()
        {

            return PlayerService.GetCF();
        }
        [Route("api/Player/CMF")]
        [HttpGet]
        public List<PlayerModel> GetCMF()
        {

            return PlayerService.GetCMF();
        }

        [Route("api/Player/DMF")]
        [HttpGet]
        public List<PlayerModel> GetDMF()
        {

            return PlayerService.GetDMF();
        }

        [Route("api/player/search/{search_text}")]
        [HttpGet]
        public List<PlayerModel> SearchPlayer(string search_text) {

            return PlayerService.SearchPlayer(search_text);
            
        }

        [Route("api/Player/CB")]
        [HttpGet]
        public List<PlayerModel> GetCB()
        {

            return PlayerService.GetCB();
        }
        [Route("api/Player/GK")]
        [HttpGet]
        public List<PlayerModel> GetGK()
        {

            return PlayerService.GetGK();
        }

    }
}
