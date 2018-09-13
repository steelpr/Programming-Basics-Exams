using System;

namespace _02.FootballKit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            decimal priceTshirt = decimal.Parse(Console.ReadLine());

            decimal priceToWin = decimal.Parse(Console.ReadLine());

            decimal percentShorts = 0.75m;

            decimal percentSocks = 0.2m;

            decimal discount = 0.15m;

            decimal priceShorts = priceTshirt * percentShorts;

            decimal priceSocks = priceShorts * percentSocks;

            decimal priceTrainers = (priceTshirt + priceShorts) * 2;

            decimal totalSum = priceTshirt + priceShorts + priceSocks + priceTrainers;

            decimal priceForPay = totalSum - (totalSum * discount);

            decimal forWin = Math.Abs(priceToWin - priceForPay);

            if (priceForPay >= priceToWin)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {priceForPay:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {forWin:f2} lv. more.");
            }
        }
    }
}
