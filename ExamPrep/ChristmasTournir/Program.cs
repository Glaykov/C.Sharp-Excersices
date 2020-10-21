using System;

namespace ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double money = 0.0;
            int dayWon = 0;
            int dayLost = 0;

            for (int i = 1; i <= days; i++)
            {
                double dailyMoney = 0.0;
                int win = 0;
                int lose = 0;

                while (true)
                {
                    string sport = Console.ReadLine();

                    if (sport == "Finish")
                    {
                        break;
                    }

                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        win += 1;
                        dailyMoney += 20;
                    }
                    else
                    {
                        lose += 1;
                    }
                }
                if (win > lose)
                {
                    dailyMoney *= 1.1;
                    dayWon += 1;
                }
                else
                {
                    dayLost += 1;
                }
                money += dailyMoney;
            }
            if (dayWon > dayLost)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {money * 1.2:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
            Console.ReadKey();
        }
    }
}