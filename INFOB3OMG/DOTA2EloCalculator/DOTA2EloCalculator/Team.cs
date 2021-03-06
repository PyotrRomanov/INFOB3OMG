﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DOTA2EloCalculator
{
    // This class holds a team of players, and their average Elo rating.
    public class Team
    {
        public List<Player> Players;
        public bool Won;
        public double AverageElo { get; set; }

        public Team()
        {
            this.Players = new List<Player>();
            this.AverageElo = 0.0;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);

            // If the team contains 5 players, we calculate the average rating of that team.
            if (Players.Count == 5)
            {
                double accumulator = 0;
                foreach (Player p in Players)
                    accumulator += p.elo;
                AverageElo = accumulator / 5;
            }
            else if (Players.Count > 5)
            {
                throw new Exception("This team has more than 5 players");
            }
        }
    }
}
