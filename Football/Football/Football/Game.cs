using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Game
    {
        public Team AlNassr { get; set; }
        public Team PsG { get; set; }
        public Referee Referee { get; set; }
        public string Winner { get; set; }
        public List <Goals> Goals = new List<Goals>();

        public Game(Team team1, Team team2, Referee referee)
        {
            if (team1.Players.Count != 11 || team2.Players.Count != 11)
            {
                throw new Exception("There must be 11 players in one team!");
            }
            AlNassr = team1;
            PsG = team2;
            Referee = referee;

        }
        public void AddGoal(int minute, Football_player player)
        {
            Goals goals = new Goals(minute, player);
            Goals.Add(goals);
        }
        public void PrintResult()
        {
            List<Goals> team1Goals = new List<Goals>();
            List<Goals> team2Goals = new List<Goals>();

            Console.WriteLine("Game result:");
            Console.WriteLine("Coach of AlNassr: " + AlNassr.Coach.Name);
            Console.WriteLine("Coach of PsG: " + PsG.Coach.Name);
            Console.WriteLine();
            foreach (var goal in Goals)
            {
                if (AlNassr.Players.Contains(goal.Player))
                {
                    team1Goals.Add(goal);
                }
                else if (PsG.Players.Contains(goal.Player))
                {
                    team2Goals.Add(goal);
                }
            }
            if (team1Goals.Count > team2Goals.Count)
            {
                Winner = "AlNassr";
                Console.WriteLine($"AlNassr wins! {team1Goals.Count}:{team2Goals.Count}");
                Console.WriteLine("AlNassr scored a goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("PsG scored goals: ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
            else if (team1Goals.Count < team2Goals.Count)
            {
                Winner = "PsG";
                Console.WriteLine($"PsG wins! {team2Goals.Count} : {team1Goals.Count}");
                Console.WriteLine("PsG scored goals: ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("AlNassr scored goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
            else
            {
                Winner = "Draw";
                Console.WriteLine("The game ends draw!");
                Console.WriteLine("AlNassr scored goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("PsG scored goals : ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
        }
    }
}
