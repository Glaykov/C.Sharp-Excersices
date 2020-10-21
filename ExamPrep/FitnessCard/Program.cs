using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyAmount = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sportType = Console.ReadLine();
            double cardPrice = 0;

            if (sex == 'f')
            {
                switch (sportType)
                {
                    case "Gym":
                        cardPrice = 35;
                        break;
                    case "Boxing":
                        cardPrice = 37;
                        break;
                    case "Yoga":
                        cardPrice = 42;
                        break;
                    case "Zumba":
                        cardPrice = 31;
                        break;
                    case "Dances":
                        cardPrice = 53;
                        break;
                    case "Pilates":
                        cardPrice = 37;
                        break;
                    default:
                        cardPrice = 0;
                        break;
                }
            }
            else if (sex == 'm')
            {
                switch (sportType)
                {
                    case "Gym":
                        cardPrice = 42;
                        break;
                    case "Boxing":
                        cardPrice = 41;
                        break;
                    case "Yoga":
                        cardPrice = 45;
                        break;
                    case "Zumba":
                        cardPrice = 34;
                        break;
                    case "Dances":
                        cardPrice = 51;
                        break;
                    case "Pilates":
                        cardPrice = 39;
                        break;
                    default:
                        cardPrice = 0;
                        break;
                }
            }

            if (age < 19)
            {
                cardPrice *= 0.8;
            }


            if (moneyAmount > cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sportType}");
            }
            else if (moneyAmount < cardPrice)
            {
                Console.WriteLine($"You dont have enough money!You need {cardPrice - moneyAmount:F2} more.");
            }

            Console.ReadKey();
        }
    }
}

