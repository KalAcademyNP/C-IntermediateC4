using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    //public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    class Stock
    {
        public string Symbol { get; set; }

        private decimal price;
        public decimal Price {
            get
            {
                return price;
            }
            set
            {
                if (value == price) return;

                PriceChanged?.Invoke(new PriceChangedEventArgs
                {
                    OldPrice = price,
                    NewPrice = value
                });
                price = value;

            }
        }

        public event Action<PriceChangedEventArgs> PriceChanged;



    }

    class PriceChangedEventArgs : EventArgs
    {
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }
}
