using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("");
            HumanPlayer humanPlayer = new HumanPlayer();
            Console.Write("Enter your name: ");
            humanPlayer.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Select your opponent (1 or 2):");
            Console.WriteLine("1. RockPlayer");
            Console.WriteLine("2. RandomPlayer");
            Console.WriteLine("");

            int opponentChoice = int.Parse(Console.ReadLine());
            Player opponent;
            if (opponentChoice == 1)
            {
                opponent = new RockPlayer();
            }
            else
            {
                opponent = new RandomPlayer();
            }
            while (true)
            {
                humanPlayer.Choice = humanPlayer.GenerateRoshambo();
                opponent.Choice = opponent.GenerateRoshambo();
                Console.WriteLine($"Your choice: {humanPlayer.Choice}");
                Console.WriteLine($"Opponent's choice: {opponent.Choice}");
                if (humanPlayer.Choice == opponent.Choice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((humanPlayer.Choice == Roshambo.Rock && opponent.Choice == Roshambo.Paper) ||
                         (humanPlayer.Choice == Roshambo.Paper && opponent.Choice == Roshambo.Scissors) ||
                         (humanPlayer.Choice == Roshambo.Scissors && opponent.Choice == Roshambo.Rock))
                {
                    Console.WriteLine("\nYou Lose!");
                }
                else
                {
                    Console.WriteLine("\nYou Win!");
                }
                Console.Write("\nPlay again? (y/n): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    break;
                    Environment.Exit(0);
                }
            }
        }
    }

}
