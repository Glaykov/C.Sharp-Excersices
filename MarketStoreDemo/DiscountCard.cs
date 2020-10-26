using System;

namespace MarketStoreDemo
{
    public class DiscountCard:OutputMethods
    {
        public CardColor cardType { get; private set; }
        public double discRate { get; private set; }
        public double turnOver { get; private set; }

        public DiscountCard(CardColor type,double turnOVER) {
            cardType = type;
            turnOver = turnOVER;
            MakeDiscRate();
        }

        private void MakeDiscRate()
        {
            switch (cardType)
            {

                case CardColor.Bronze:
                    if (turnOver < 100)
                    {
                        discRate = 0;
                    }
                    else if (turnOver > 100 && turnOver < 300)
                    {
                        discRate = 0.01;
                    }
                    else if (turnOver > 300)
                    {
                        discRate = 0.025;
                    }
                    break;

                case CardColor.Silver:
                    if (turnOver > 300)
                    {
                        discRate = 0.035;
                    }
                    else discRate = 0.02;
                    break;

                case CardColor.Gold:
                    if (Math.Floor(turnOver / 100) >= 8)
                    {
                        discRate = 0.1;
                    }
                    else if (Math.Floor(turnOver / 100) < 1)
                    {
                        discRate = 0.02;

                    }
                    else if ((((Math.Floor(turnOver / 100)) / 100) + 0.02) > 0.1)
                    {
                        discRate = 0.1;

                    }
                    else if (turnOver >= 700 && turnOver <= 799) 
                    {
                        discRate = 0.09;
                    }
                    else discRate = ((Math.Floor(turnOver / 100)) / 100) + 0.02;
                    break;
            }
        }   
    }
}
