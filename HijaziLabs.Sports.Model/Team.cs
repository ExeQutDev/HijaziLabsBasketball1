using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HijaziLabs.Sports.Model
{
    public class Team
    {
        public Team() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public string League { get; set; }
        public int Rank { get; set; }

        public List<Player> Players { get; set; }
    }
}
