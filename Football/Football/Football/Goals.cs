using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Goals
    {
        public int Minute { get; set; }
        public Football_player Player { get; set; }
        public Goals(int minute, Football_player player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
