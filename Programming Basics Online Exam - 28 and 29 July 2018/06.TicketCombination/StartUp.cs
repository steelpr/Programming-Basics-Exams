using System;
using System.Collections.Generic;

namespace _06.TicketCombination
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string combination = string.Empty;

            int index = 0;

            int profit = 0;

            while (true)
            {
                for (char first = 'B'; first <= 'L'; first += (char)2)
                {
                    for (char second = 'f'; second >= 'a'; second--)
                    {
                        for (char third = 'A'; third <= 'C'; third++)
                        {
                            for (int fourth = 1; fourth <= 10; fourth++)
                            {
                                for (int fifth = 10; fifth >= 1; fifth--)
                                {
                                    index++;

                                    if (index == number)
                                    {
                                        combination = first.ToString() + second.ToString() + third.ToString() + fourth.ToString() + fifth.ToString();

                                        profit = first + second + third + fourth + fifth;

                                        goto result;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            result:

            Console.WriteLine($"Ticket combination: {combination}");

            Console.WriteLine($"Prize: {profit} lv.");
        }
    }
}
