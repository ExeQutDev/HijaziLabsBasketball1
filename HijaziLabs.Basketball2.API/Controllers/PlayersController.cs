using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijaziLabs.Basketball2.Interfaces;
using HijaziLabs.Sports.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HijaziLabs.Basketball2.API.Controllers
{


    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {

        private ITeamsService _teamsService;

        public PlayersController(ITeamsService teamsService)
        {
            _teamsService = teamsService;
        }


   
    }
}