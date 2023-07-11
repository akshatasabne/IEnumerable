using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable12
{
    public class Player
    {
        public int run;
        public string name;

        public Player(int run, string name)
        {
            this.run = run;
            this.name = name;
        }

        public override string ToString()
        {
            return$"Player Runs={run}--Player Name={name}";
        }
    }

    public class Team :IEnumerable
    {
        Player[] player;

        public Team()
        {
            player=new Player[3];
            player[0] = new Player(100,"Sachin");
            player[1] = new Player(200, "Dhoni");
            player[2] = new Player(100, "Virat");

        }
        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }
}
