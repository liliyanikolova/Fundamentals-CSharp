using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines.Models
{
    public class Player
    {
        private string name;

        private int points;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public Player()
        {
        }

        public string Name { get; set; }
 
        public int Points { get; set; }
    }
}
