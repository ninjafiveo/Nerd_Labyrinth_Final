using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_Final
{
    class New_Player
    {

        public string Name;
        public int Age;
        public double PlayerLuck;
        public int PlayerScore;
        public string PlayerNumber;

        public New_Player(string name, int age, int playerScore, string playerNumber)
        {
            this.Name = name;
            this.Age = age;
            this.PlayerScore = playerScore;
            this.PlayerNumber = playerNumber;
        }

        public static double PlayerLuckRoll(int age)
        {
            Random dice_number = new Random();
            double luckMultiplier = dice_number.NextDouble();
            double PlayerLuck = luckMultiplier * age;
            //Console.WriteLine($"luckMultiplier = {luckMultiplier}");
            //Console.WriteLine($"playerLuckMultiplier = {playerLuckMultiplier}");
            return PlayerLuck;
        }



    }
}
