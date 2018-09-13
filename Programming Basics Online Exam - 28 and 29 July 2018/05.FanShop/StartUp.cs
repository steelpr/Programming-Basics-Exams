using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> articleInShop = new Dictionary<string, int>()
            {
                { "hoodie", 30},
                {"keychain", 4 },
                {"T-shirt", 20 },
                {"flag", 15 },
                {"sticker", 1 }
            };

            int budget = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                string souvenir = Console.ReadLine();

                sum += articleInShop.FirstOrDefault(x => x.Key == souvenir).Value;
            }

            int needMoney = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine($"You bought {number} items and left with {needMoney} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {needMoney} more lv.");
            }
        }
    }
}
