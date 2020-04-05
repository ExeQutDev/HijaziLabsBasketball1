using HijaziLabs.Basketball2.Interfaces;
using HijaziLabs.Sports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HijaziLabs.Basketball2.StaticServices
{
    public class TeamsService : ITeamsService
    {
        private static int counter = 0;
        private static List<Team> Teams = new List<Team>();

        public Team AddTeam(Team team)
        {

            team.ID = ++counter;
            Teams.Add(team);
            return team;
        }

        public Team GetTeam(int id)
        {
            var matchingTeam = Teams.SingleOrDefault(t => t.ID == id);
            return matchingTeam;
        }

        public List<Team> GetTeams()
        {
            return Teams;
        }

        public void UpdateTeam(Team updatedTeam)
        {
            var team = GetTeam(updatedTeam.ID);
            if (team != null)
            {
                team.Name = updatedTeam.Name;
                team.League = updatedTeam.League;
                team.Rank = updatedTeam.Rank;
            }
        }
    }
}
