using System;

namespace _04.GroupStage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();

            int numberMatch = int.Parse(Console.ReadLine());

            int score = 0;

            int different = 0;

            int sumInsertedGoal = 0;

            int sumreceivedGoal = 0;

            for (int i = 0; i < numberMatch; i++)
            {
                int insertedGoal = int.Parse(Console.ReadLine());

                int receivedGoal = int.Parse(Console.ReadLine());

                sumInsertedGoal += insertedGoal;

                sumreceivedGoal += receivedGoal;

                if (insertedGoal == receivedGoal)
                {
                    score += 1;
                }
                else if (insertedGoal > receivedGoal)
                {
                    score += 3;
                }

                different += insertedGoal - receivedGoal;
            }

            if (sumInsertedGoal >= sumreceivedGoal)
            {
                Console.WriteLine($"{team} has finished the group phase with {score} points.");
                Console.WriteLine($"Goal difference: {different}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {different}.");
            }
        }
    }
}
