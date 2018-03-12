using System;

namespace Pay
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter les heures");
            for (int i = 1; i < 1000; i++)
            {
                double total = 0;
                string number = Console.ReadLine();
                if (!VldInt(number))
                {
                    Console.WriteLine("Error");
                    continue;
                }
                if (int.Parse(number) < 0)
                {
                    Console.WriteLine("Error les heures");
                    continue;
                }
                if (int.Parse(number) < 35)
                {
                    total = int.Parse(number) * 8;
                }
                else if (int.Parse(number) >= 35 && int.Parse(number) < 45)
                {
                    total = 35 * 8 + ((int.Parse(number) - 35) * 8 * 1.25);
                }
                else if (int.Parse(number) >= 45)
                {
                    total = 35 * 8 + (10 * 8 * 1.25) + ((int.Parse(number) - 45) * 8 * 1.5);
                }
                Console.WriteLine("SG est{0}, chomage est{1}, retraite est {2}", total * 11.3 / 100, total * 2.12 / 100, total * 1.84 / 100);

            }

           
        }
        static public bool VldInt(string num)
        {
            #region
            int ResultNum;
            return int.TryParse(num, out ResultNum);
            #endregion
        }
    }
}