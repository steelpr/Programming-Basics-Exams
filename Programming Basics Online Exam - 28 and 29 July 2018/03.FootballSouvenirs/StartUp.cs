using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FootballSouvenirs
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Dictionary<string, decimal> argentina = new Dictionary<string, decimal>()
            {
                {"flags", 3.25m},
                {"caps", 7.20m},
                {"posters", 5.10m},
                {"stickers", 1.25m},
            };

            Dictionary<string, decimal> brazil = new Dictionary<string, decimal>()
            {
                {"flags", 4.20m},
                {"caps", 8.50m},
                {"posters", 5.35m},
                {"stickers", 1.20m},
            };

            Dictionary<string, decimal> croatia = new Dictionary<string, decimal>()
            {
                {"flags", 2.75m},
                {"caps", 6.90m},
                {"posters", 4.95m},
                {"stickers", 1.10m},
            };

            Dictionary<string, decimal> denmark = new Dictionary<string, decimal>()
            {
                {"flags", 3.10m},
                {"caps", 6.50m},
                {"posters", 4.80m},
                {"stickers", 0.90m},
            };

            string team = Console.ReadLine();

            string typeSouvenir = Console.ReadLine();

            int numberSouvenirs = int.Parse(Console.ReadLine());

            Console.WriteLine(Output(argentina, brazil, croatia, denmark, team, typeSouvenir, numberSouvenirs));
        }

        private static string Output(Dictionary<string, decimal> argentina, Dictionary<string, decimal> brazil, Dictionary<string, decimal> croatia, Dictionary<string, decimal> denmark, string team, string typeSouvenir, int numberSouvenirs)
        {
            string output = "Pepi bought {0} {1} of {2} for {3} lv.";

            if (team == "Argentina")
            {
                if (!argentina.ContainsKey(typeSouvenir))
                {
                    return "Invalid stock!";
                }

                decimal price = argentina.Where(x => x.Key == typeSouvenir).Sum(x => numberSouvenirs * x.Value);

                return string.Format((output), numberSouvenirs, typeSouvenir, team, price);
            }
            else if (team == "Brazil")
            {
                if (!brazil.ContainsKey(typeSouvenir))
                {
                    return "Invalid stock!";
                }

                decimal price = brazil.Where(x => x.Key == typeSouvenir).Sum(x => numberSouvenirs * x.Value);

                return string.Format((output), numberSouvenirs, typeSouvenir, team, price);
            }
            else if (team == "Croatia")
            {

                if (!croatia.ContainsKey(typeSouvenir))
                {
                    return "Invalid stock!";
                }

                decimal price = croatia.Where(x => x.Key == typeSouvenir).Sum(x => numberSouvenirs * x.Value);

                return string.Format((output), numberSouvenirs, typeSouvenir, team, price);
            }
            else if (team == "Denmark")
            {
                if (!denmark.ContainsKey(typeSouvenir))
                {
                    return "Invalid stock!";
                }

                decimal price = denmark.Where(x => x.Key == typeSouvenir).Sum(x => numberSouvenirs * x.Value);

                return string.Format((output), numberSouvenirs, typeSouvenir, team, price);
            }

            return "Invalid country!";
        }
    }
}
