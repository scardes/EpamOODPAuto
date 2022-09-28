using System;
using System.Collections.Generic;
using System.Text;

namespace EpamOODPAuto
{
    public class Cars
    {
        int count = 0;
        int price = 0;
        public int Count
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Count should be greater than 0");
                }
                else
                {
                    count = value;
                }
            }
            get
            {
                return count;
            }
        }
        public int Price
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price should be greater than 0");
                }
                else
                {
                    price = value;
                }
            }
            get
            {
                return price;
            }
        }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
