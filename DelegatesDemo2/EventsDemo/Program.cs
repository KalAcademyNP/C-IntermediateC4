using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStock = new Stock
            {
                Symbol = "MSFT",
                Price = 120.45M
            };

            myStock.PriceChanged += NotifyMe;
            myStock.PriceChanged += NotifyMeAgain;

            myStock.Price = 150;
            myStock.PriceChanged -= NotifyMeAgain;

            myStock.Price = 200;
        }

        static void NotifyMe(PriceChangedEventArgs args)
        {
            Console.WriteLine($"oldprice: {args.OldPrice}, newPrice: {args.NewPrice}");
        }

        static void NotifyMeAgain(PriceChangedEventArgs args)
        {
            Console.WriteLine($"Again - oldprice: {args.OldPrice}, newPrice: {args.NewPrice}");
        }
    }
}
