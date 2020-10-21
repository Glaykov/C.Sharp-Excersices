using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luggage
{
    class Program
    {
        static void Main(string[] args)
        {
            double cappacity = double.Parse(Console.ReadLine());

   
            int counter = 0;
            while (true) {
                counter++;
                string input = Console.ReadLine();

                if (input == "End") {
                    Console.WriteLine($"Congratulations! All suitcases are loaded! Statistic: {--counter} suitcases loaded.");
                    break;
                }
                double bag = Convert.ToDouble(input);
                if (counter % 3 == 0) { 
                    bag *= 1.1;
                }
                cappacity -= bag;
                if (cappacity < 0) {
                    Console.WriteLine($"No more space! Statistic: {--counter} loaded.");
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
