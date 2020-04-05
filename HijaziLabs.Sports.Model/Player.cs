using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HijaziLabs.Sports.Model
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public int Fouls { get; set; }
        public int TeamId { get; set; }
        // team
        public Team Team { get; set; }
    }
}
