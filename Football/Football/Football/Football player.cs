using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public abstract class Football_player:Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public Football_player(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
