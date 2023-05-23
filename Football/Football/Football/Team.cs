using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<Football_player> players;
        public List<Football_player> Players
        {
            get { return players; }
            set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new Exception("The minimum team members must be 11 up to 22!");
                }
                players = value;
            }
        }
        public Team(Coach coach, List<Football_player> players)
        {
            Coach = coach;
            Players = players;
        }

        public double Average_age
        {
            get
            {
                int totalAge = 0;
                foreach (var item in Players)
                {
                    totalAge += item.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
    }
}
