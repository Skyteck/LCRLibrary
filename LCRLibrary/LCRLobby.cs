using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCRLibrary
{
    public class LCRLobby
    {
        List<LCRPlayer> currentPlayers = new List<LCRPlayer>();
        int activePlaceIndex;

        public string Id { get; }
        public int Players { get; }

        public LCRLobby(string id, int players = 3)
        {
            Id = id;
            Players = players;
            Random nr = new Random();
            activePlaceIndex = nr.Next(0, players);
        }

        public void AddPlayer()
        {
            LCRPlayer p = new LCRPlayer();
            AddPlayer(p);
        }

        public void AddPlayer(LCRPlayer p)
        {
            currentPlayers.Add(p);
        }
    }
}
