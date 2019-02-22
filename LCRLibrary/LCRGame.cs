using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCRLibrary
{
    class LCRGame
    {
        public int id;
        List<LCRPlayer> currentPlayers = new List<LCRPlayer>();
        int activePlaceIndex = 0;
        public LCRGame()
        {
            Random idGen = new Random();
            id = idGen.Next();
        }

        public void AddPlayer(LCRPlayer p)
        {
            currentPlayers.Add(p);
        }
    }
}
