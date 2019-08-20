using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    
      interface Iitem
        {
            double GetVat();
        }

        public abstract class Item
        {
            public string ImageUrl;
            public double Price;
            public abstract double GetVat();
        }

        public class Product : Item
        {
            public string Name;
            public override double GetVat()
            {
                return Price * 15 / 100;
            }
        }
        public class GiftCard : Item
        {
            public string ReceiverEmailAddress;

            public override double GetVat()
            {
                return 0;
            }
        }

        class ShoppingCart
        {
            public Item[] items;
        }
    

}

