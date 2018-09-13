using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BestPlayer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> players = new Dictionary<string, int>();

            string namePlayer = string.Empty;

            while (true)
            {
                namePlayer = Console.ReadLine();

                if (namePlayer == "END")
                {
                    break;
                }

                int numberGoal = int.Parse(Console.ReadLine());

                players.Add(namePlayer, numberGoal);

                if (numberGoal >= 10)
                {
                    break;
                }
            }

            var player = players.FirstOrDefault(x => x.Value == players.Values.Max());

            Console.WriteLine($"{player.Key} is the best player!");

            if (player.Value >= 3)
            {
                Console.WriteLine($"He has scored {player.Value} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {player.Value} goals.");
            }
        }
    }
}
