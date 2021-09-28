using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_Final
{

    class Game_Start
    {
        
        public static void Intro_To_Game()
        {
            
            Console.WriteLine("Welcome. How many players: ");
            int number_of_players = Convert.ToInt32(Console.ReadLine());
            List<New_Player> NewPlayer = new List<New_Player>();

            for (int i = 0; i < number_of_players; i++)
            {
                string playerNumber = "player" + (i + 1);
                Console.Write($"Welcome Player{i + 1}, please enter your name: ");
                string playerName = Console.ReadLine();

                Console.WriteLine($"Thanks for joining the game {playerName}. Please enter your age: ");
                int playerAge = Convert.ToInt32(Console.ReadLine());

                New_Player Competitor = new New_Player(playerName, playerAge, 0, playerNumber);
                Console.WriteLine($"Let's see if it works... {Competitor.PlayerNumber} is {Competitor.Name} and is {Competitor.Age} years old.");
                Console.WriteLine("");
                NewPlayer.Add(new New_Player(playerName, playerAge, 0, playerNumber));
            }


            

            foreach (var player in NewPlayer)
            {
                Console.WriteLine($"Player Number: {player.PlayerNumber} || Player Name: {player.Name} || Player Age: {player.Age}");
                
            }

        }

        public static void Player_Check()
        {
            Console.WriteLine();
        }


    }
}
