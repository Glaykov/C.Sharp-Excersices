using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrekingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int Musala = 0;
            int Montblanc = 0;
            int Kilimanjaro = 0;
            int K2 = 0;
            int Everest = 0;
            
            

            for (int i = 1; i <= groups; i++) {

                int trekkers = int.Parse(Console.ReadLine());
               
                if (trekkers <= 5)
                {
                    Musala += trekkers;
                }
                else if (trekkers >= 6 && trekkers <= 12)
                {
                    Montblanc += trekkers;
                }
                else if (trekkers >= 13 && trekkers <= 25)
                {
                    Kilimanjaro += trekkers;
                }
                else if (trekkers >= 26 && trekkers <= 40)
                {
                    K2 += trekkers;
                }
                else if (trekkers >= 41) {
                    Everest += trekkers;
                }
            }
            double all = Musala + Montblanc + Kilimanjaro + K2 + Everest;
            Console.WriteLine($"{Musala / all * 100:f2}%");
            Console.WriteLine($"{Montblanc / all * 100:f2}%");
            Console.WriteLine($"{Kilimanjaro / all * 100:f2}%");
            Console.WriteLine($"{K2 / all * 100:f2}%");
            Console.WriteLine($"{Everest / all * 100:f2}%");



            Console.ReadKey();
        }
    }
}
