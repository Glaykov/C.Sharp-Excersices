using System;

namespace MarketStoreDemo
{
    public class OutputMethods
    {
        public void ShowPurchaseValue(double purchase) {
            Console.WriteLine($"Purchase value: ${purchase:f2}");
        }
        public void ShowDiscountRate(double rate) {
            Console.WriteLine($"Discount rate: {rate*100}%");
        }
        public void ShowDiscount(double purchase, double rate) {
            Console.WriteLine($"Discount: ${purchase*rate:F2}");
        }
        public void ShowTotal(double purchase,double rate) {
            Console.WriteLine($"Discount: ${purchase-(purchase * rate):F2}");
        }
    }
}
