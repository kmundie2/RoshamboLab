using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoshamboLab
{
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }

    class RandomPlayer : Player
    {
        public Random random = new Random();
        public override Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            return (Roshambo)values.GetValue(random.Next(values.Length));
        }
    }
    class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("\nChoose your move: (1-3)");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            string userInput = Console.ReadLine().ToLower();

            if (Enum.TryParse(userInput, out Roshambo userChoice))
            {
                return userChoice;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose Rock, Paper, or Scissors.");
                return GenerateRoshambo();
            }
        }
    }
}
