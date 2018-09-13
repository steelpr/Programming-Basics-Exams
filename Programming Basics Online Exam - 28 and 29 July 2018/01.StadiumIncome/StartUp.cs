using System;

namespace _01.StadiumIncome
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            decimal priceForTicket = decimal.Parse(Console.ReadLine());

            decimal incomeForOneSector = (capacity * priceForTicket) / sectors;

            decimal totalIncome = incomeForOneSector * sectors;

            decimal moneyForCharity = (totalIncome - (incomeForOneSector * 0.75m)) / 8;

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");

            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
