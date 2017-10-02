// Michael Eckel
// 5-11-17
// Player Class - used to create a new player
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    public class Player    
    {
        public string Name { get; set; }
        public string Team { get; set; } // red team or black team

        public Player(){ }

        public Player(string playerName, string team)
        {
            this.Name = playerName;
            this.Team = team;
        }
    }
}
