using System;

namespace ExamPrep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int b = 1168; //leva
            double y = 0.15; // dolar
            double Dollar = 1.76; // leva 
            double euro = 1.95; // leva

            int bitCoin = int.Parse(Console.ReadLine()); 
            double chinaYoan = float.Parse(Console.ReadLine());
            double commision = float.Parse(Console.ReadLine());
            double commisionFinal = (100 - commision) / 100;

            
            double bitkoinVleva = bitCoin * b; // bitkoin v leva
            double yoanVleva = (chinaYoan * y) * Dollar ; // yoan v leva

            double bitkonVevro = bitkoinVleva / euro; // bitkoin v evro
            double yoanVevro = yoanVleva / euro; //yoan v evro 
            double exchange = bitkonVevro + yoanVevro;
            double exchangeKraina = exchange * commisionFinal;

            Console.WriteLine(Math.Round(exchangeKraina,2));


            Console.ReadKey();
        }
    }
}
