using System;

namespace _05.GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();

            int playedMatch = int.Parse(Console.ReadLine());

            int allTime = 0;

            int penalties = 0;

            int additionaltime = 0;


            for (int i = 0; i < playedMatch; i++)
            {
                int time = int.Parse(Console.ReadLine());

                allTime += time;

                if (time > 120)
                {
                    penalties += 1;
                }
                else if (time > 90 && time <= 120)
                {
                    additionaltime += 1;
                }
            }

            double average = (double)allTime / playedMatch;

            Console.WriteLine($"{team} has played {allTime} minutes. Average minutes per game: {average:f2}");

            Console.WriteLine($"Games with penalties: {penalties}");

            Console.WriteLine($"Games with additional time: {additionaltime}");
        }
    }
}
