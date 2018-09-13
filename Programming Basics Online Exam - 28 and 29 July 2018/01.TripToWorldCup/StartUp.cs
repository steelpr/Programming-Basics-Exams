using System;

namespace _01.TripToWorldCup
{
    class StartUp
    {
        static void Main(string[] args)
        {
            decimal priceTicketToGo = decimal.Parse(Console.ReadLine());

            decimal priceTicketToBack = decimal.Parse(Console.ReadLine());

            decimal priceTicketForOneMatch = decimal.Parse(Console.ReadLine());

            int numberMatch = int.Parse(Console.ReadLine());

            int percentDiscount = int.Parse(Console.ReadLine());

            decimal priceTickets = 6 * (priceTicketToGo + priceTicketToBack);

            decimal priceAfterDiscount = priceTickets - (priceTickets * (percentDiscount / 100m));

            decimal priceForTickets = 6 * numberMatch * priceTicketForOneMatch;

            decimal totalSum = priceForTickets + priceAfterDiscount;

            decimal sumForEachOne = totalSum / 6;

            Console.WriteLine($"Total sum: {totalSum:f2} lv.");

            Console.WriteLine($"Each friend has to pay {sumForEachOne:f2} lv.");
        }
    }
}
