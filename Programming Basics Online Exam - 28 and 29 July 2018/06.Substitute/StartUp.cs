using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberOne = int.Parse(Console.ReadLine());

            int secondNumberOne = int.Parse(Console.ReadLine());

            int firstNumberTwo = int.Parse(Console.ReadLine());

            int secondNumbertwo = int.Parse(Console.ReadLine());

            int index = 0;

            for (int first = firstNumberOne; first <= 8; first++)
            {
                for (int second = 9; second >= secondNumberOne; second--)
                {
                    for (int third = firstNumberTwo; third <= 8; third++)
                    {
                        for (int fourth = 9; fourth >= secondNumbertwo; fourth--)
                        {
                            bool isValid = first % 2 == 0 && second % 2 != 0 && third % 2 == 0 && fourth % 2 != 0;

                            int firstNumber = first * 10 + second;

                            int secondNumber = third * 10 + fourth;

                            if (isValid && firstNumber == secondNumber)
                            {
                                Console.WriteLine("Cannot change the same player.");
                                index++;
                            }
                            else if (isValid && firstNumber != secondNumber)
                            {
                                Console.WriteLine($"{first}{second} - {third}{fourth}");
                                index++;
                            }

                            if (index == 6)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            } 
        }
    }
}
