using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijaziLabs.Basketball2.Interfaces;
using HijaziLabs.Basketball2.StaticServices;
using HijaziLabs.Sports.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HijaziLabs.Basketball2.API.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class BasketballTeamsController : ControllerBase
    {
        private ITeamsService _teamsService;

        
        public BasketballTeamsController(ITeamsService teamsService)
        {
            _teamsService = teamsService;
        }

        [HttpGet("")]
        public List<Team> GetAll()
        {
            return _teamsService.GetTeams();
        }

        [HttpGet("{id}")] //api/teams/2
        public Team GetTeam([FromRoute]int id)
        {
            var matchingTeam = _teamsService.GetTeam(id);
            if (matchingTeam == null)
            {
                Response.StatusCode = 404;
                Response.WriteAsync(String.Format("Team with ID {0} not found", id));
            }
            return matchingTeam;
        }

        [HttpPost]
        public Team AddTeam([FromBody]Team team)
        {
            if (team == null || String.IsNullOrWhiteSpace(team.Name))
            {
                Response.StatusCode = 400;
                Response.WriteAsync("Must include team name");
                return null;
            }

            var addedTeam = _teamsService.AddTeam(team);
            return addedTeam;
        }

        [HttpPut]
        public void Update(Team team)
        {
            var teamToUpdate = GetTeam(team.ID);
            if(teamToUpdate == null)
            {
                return;
            }

            _teamsService.UpdateTeam(team);
        }

    }
}