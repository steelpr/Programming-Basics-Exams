using System;

namespace _03.GameStatistics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());

            string namePlayer = Console.ReadLine();

            Console.WriteLine(HalfTime(minutes));

            Output(namePlayer, minutes);
        }

        private static void Output(string nameGamer, int minutes)
        {
            bool isOdd = minutes % 2 == 0;

            if (minutes >= 1 && minutes <= 10)
            {
                Console.WriteLine($"{nameGamer} missed a penalty.");

                if (isOdd)
                {
                    Console.WriteLine($"{nameGamer} was injured after the penalty.");
                }
            }
            else if (minutes > 10 && minutes <= 35)
            {
                Console.WriteLine($"{nameGamer} received yellow card.");

                if (!isOdd)
                {
                    Console.WriteLine($"{nameGamer} got another yellow card.");
                }
            }
            else if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine($"{nameGamer} SCORED A GOAL !!!");
            }
            else if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine($"{nameGamer} got a freekick.");

                if (isOdd)
                {
                    Console.WriteLine($"{nameGamer} missed the freekick.");
                }
            }
            else if (minutes > 55 && minutes <= 80)
            {
                Console.WriteLine($"{nameGamer} missed a shot from corner.");

                if (!isOdd)
                {
                    Console.WriteLine($"{nameGamer} has been changed with another player.");
                }
            }
            else if (minutes > 80 && minutes <= 90)
            {
                Console.WriteLine($"{nameGamer} SCORED A GOAL FROM PENALTY !!!");
            }
        }

        private static string HalfTime(int minutes)
        {
            const string zeroMinutes = "Match has just began!";

            const string firstHalfTime = "First half time.";

            const string secondHalfTime = "Second half time.";

            if (minutes == 0)
            {
                return zeroMinutes;
            }
            else if (minutes < 45)
            {
                return firstHalfTime;
            }

            return secondHalfTime;
        }
    }
}
