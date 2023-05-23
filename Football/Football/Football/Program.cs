using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach AlCoach = new Coach("Rudi Garcia",50);
            Goalkeeper AlGoalkeeper = new Goalkeeper("Agustín Rossi", 32, 1, 188);
            Goalkeeper AlGoalkeeper2 = new Goalkeeper("David Ospina", 29, 2, 186);
            Defender AlDefender1 = new Defender("Ali Al-Hassan", 27, 13, 183);
            Defender AlDefender2 = new Defender("Abdullah Al-Khaibari", 28, 26, 186);
            Defender AlDefender3 = new Defender("Luiz Gustavo", 30, 15, 180);
            Midfield AlMidfield1 = new Midfield("Talisca", 23, 23, 191);
            Midfield AlMidfield2 = new Midfield("Pity Martínez", 30, 24, 182);
            Midfield AlMidfield3 = new Midfield("Sami Al-Najei", 25, 16, 188);
            Striker AlStriker1 = new Striker("Meshari Al-Nemer", 34, 12, 185);
            Striker AlStriker2 = new Striker("Mohammed Maran", 26, 5, 187);
            Striker AlStriker3 = new Striker("Cristiano Ronaldo", 37, 7, 190);
            List<Football_player> team1Players = new List<Football_player>
            {
                AlGoalkeeper,
                AlGoalkeeper2,
                AlDefender1,
                AlDefender2,
                AlDefender3,
                AlMidfield1,
                AlMidfield2,
                AlMidfield3,
                AlStriker1,
                AlStriker2,
                AlStriker3,
            };
            Team team1 = new Team(AlCoach, team1Players);

            Coach PsGCoach = new Coach("Christophe Galtier", 44);
            Goalkeeper PsGGoalkeeper = new Goalkeeper("Gianluigi Donnarumma", 26, 1, 186);
            Goalkeeper PsGGoalkeeper2 = new Goalkeeper("Sergio Rico", 29, 2, 187);
            Defender PsGDefender1 = new Defender("Juan Bernat", 26, 8, 183);
            Defender PsGDefender2 = new Defender("Achraf Hakimi", 22, 16, 186);
            Defender PsGDefender3 = new Defender("Nordi Mukiele", 31, 11, 188);
            Midfield PsGMidfield1 = new Midfield("Danilo Pereira", 34, 9, 189);
            Midfield PsGMidfield2 = new Midfield("Marco Verratti", 27, 3, 183);
            Midfield PsGMidfield3 = new Midfield("Fabián Ruiz", 33, 3, 179);
            Striker PsGStriker1 = new Striker("Kylian Mbappé", 24, 24, 190);
            Striker PsGStriker2 = new Striker("Hugo Ekitiké", 29, 20, 186);
            Striker PsGStriker3 = new Striker("Ilyes Housni", 27, 18, 189);

            List<Football_player> team2Players = new List<Football_player>
            {
                PsGGoalkeeper,
                PsGGoalkeeper2,
                PsGDefender1,
                PsGDefender2,
                PsGDefender3,
                PsGMidfield1,
                PsGMidfield2,
                PsGMidfield3,
                PsGStriker1,
                PsGStriker2,
                PsGStriker3,
            };
            Team team2 = new Team(PsGCoach, team2Players);
            Referee MainReferee = new Referee("Pablo Gaston Echavarria", 55);
            Referee Assistant1 = new Referee("Fernando Gabriel Echenique", 45);
            Referee Assistant2 = new Referee("Yael Cristian Falcon Perez", 47);

            Game game = new Game(team1, team2, MainReferee);
            game.AddGoal(57, AlStriker1);
            game.AddGoal(20, AlStriker3);
            game.AddGoal(72, AlStriker3);

            game.AddGoal(23, PsGStriker1);
            game.AddGoal(70, PsGStriker3);
            game.PrintResult();
        }
    }
}
