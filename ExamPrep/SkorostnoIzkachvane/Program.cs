using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkorostnoIzkachvane
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double secondsFor1Meter = double.Parse(Console.ReadLine());

            double GeorgeDelay = (Math.Floor(distanceMeters / 50)) * 30;
            double GeorgesRecord = (distanceMeters * secondsFor1Meter) + GeorgeDelay;

            double no = GeorgesRecord - recordSeconds;


            if (GeorgesRecord > recordSeconds)
            {
                Console.WriteLine($"No! He was {no:F2} seconds slower!");
            }
            else if (recordSeconds > GeorgesRecord)
            {
                Console.WriteLine($"Yes! The new record is {GeorgesRecord:F2} seconds.");
            }else if (recordSeconds == GeorgesRecord)
            {
                Console.WriteLine("No! He was 0.00 seconds slower.");
            }

            Console.ReadKey();
            
        }
    }
}
