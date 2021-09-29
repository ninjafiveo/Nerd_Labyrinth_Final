using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Game_Start.Intro_To_Game();
            Console.WriteLine("Below is the player check()");
            Game_Start.Player_Check();
            AddPoints(1);
            AddPoints(1);
            AddPoints(1);
            AddPoints(2);
            AddPoints(1);
            Console.ReadKey();
        }

        public static int AddPoints(int playerNumber)
        {

            Console.WriteLine($"{Game_Start.NewPlayer[playerNumber].Name} current score is: {Game_Start.NewPlayer[playerNumber].PlayerScore}");

            Game_Start.NewPlayer[playerNumber].PlayerScore = Game_Start.NewPlayer[playerNumber].PlayerScore + 1;

            Console.WriteLine($"{Game_Start.NewPlayer[playerNumber].Name} New Score is now:  {Game_Start.NewPlayer[playerNumber].PlayerScore}");

            return Game_Start.NewPlayer[playerNumber].PlayerScore;

        }
    }
}
