using System;

namespace MarketStoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DiscountCard cardBronze = new DiscountCard(CardColor.Bronze,0);
            cardBronze.ShowPurchaseValue(150);
            cardBronze.ShowDiscountRate(cardBronze.discRate);
            cardBronze.ShowDiscount(150, cardBronze.discRate);
            cardBronze.ShowTotal(150, cardBronze.discRate);

            Console.WriteLine();

            DiscountCard cardSilver = new DiscountCard(CardColor.Silver, 600);
            cardSilver.ShowPurchaseValue(850);
            cardSilver.ShowDiscountRate(cardSilver.discRate);
            cardSilver.ShowDiscount(850, cardSilver.discRate);
            cardSilver.ShowTotal(850, cardSilver.discRate);

            Console.WriteLine();

            DiscountCard cardGold = new DiscountCard(CardColor.Gold, 1500);
            cardGold.ShowPurchaseValue(1300);
            cardGold.ShowDiscountRate(cardGold.discRate);
            cardGold.ShowDiscount(1300, cardGold.discRate);
            cardGold.ShowTotal(1300, cardGold.discRate);





            Console.ReadKey();
        }
    }
}
