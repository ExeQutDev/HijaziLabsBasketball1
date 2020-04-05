using HijaziLabs.Sports.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HijaziLabs.Basketball2.Interfaces
{
    public interface ITeamsService
    {
        Team GetTeam(int id);

        Team AddTeam(Team team);

        void UpdateTeam(Team updatedTeam);

        List<Team> GetTeams();

    }
}
