using System;

namespace _02.BeerAndChips
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string nameFan = Console.ReadLine();

            decimal budget = decimal.Parse(Console.ReadLine());

            int bottleBeer = int.Parse(Console.ReadLine());

            int packageChips = int.Parse(Console.ReadLine());

            decimal priceBeer = 1.20m;

            decimal percent = 0.45m;

            decimal priceBeers = bottleBeer * priceBeer;

            decimal priceOneChips = priceBeers * percent;

            decimal priceChips = Math.Ceiling(priceOneChips * packageChips);

            decimal totalSum = priceBeers + priceChips;

            decimal money = budget - totalSum;

            if (money < 0)
            {
                Console.WriteLine($"{nameFan} needs {Math.Abs(money):f2} more leva!");
            }
            else
            {
                Console.WriteLine($"{nameFan} bought a snack and has {money:f2} leva left.");
            }
        }
    }
}
