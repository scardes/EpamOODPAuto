using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Singleton class of Auto Database
/// </summary>
namespace EpamOODPAuto
{
    public sealed class AutoSingleBase
    {
        private AutoSingleBase() { }

        private static AutoSingleBase _instance;

        public static AutoSingleBase GetAutoBase()
        {
            if (_instance == null)
            {
                _instance = new AutoSingleBase();
            }
            return _instance;
        }

        public void businessLogic()
        {
            string? brand = string.Empty;
            string? model = string.Empty;
            int count;
            int price;

            bool correctInput = false;

            var theCars = new List<Cars>();

            theCars = new List<Cars>()
                {
                    new Cars() { Brand = "Volvo", Model = "VC300", Count = 10, Price = 80000},
                    new Cars() { Brand = "Volvo", Model = "A777", Count = 13, Price = 10000 },
                    new Cars() { Brand = "Mersedes", Model = "S500", Count = 7, Price = 770000},
                    new Cars() { Brand = "Honda", Model = "Civic", Count = 40, Price = 20000}
                };

            while (!correctInput)
            {
                try
                {
                    Console.WriteLine("Please enter information about cars: brand, model, count, price for one car");
                    string[] arr = Console.ReadLine().Split();

                    brand = arr[0];
                    model = arr[1];
                    int.TryParse(arr[2], out count);
                    int.TryParse(arr[3], out price);

                    theCars.Add(new Cars() { Brand = brand, Model = model, Count = count, Price = price });
                    correctInput = true;
                }
                catch
                {
                    Console.WriteLine("Input error. Please input correct information 1=brand, 2=model, 3=count, 4=price for one car");
                }
            }

            Console.WriteLine("\n LIST OF CAR: \n");
            foreach (var cars in theCars)
            {
                Console.WriteLine($"{cars.Brand} {cars.Model} {cars.Count} {cars.Price} ");
            }

            // Start new logic

            // count types
            var countTypes = (from se in theCars
                              select se).Count();

            Console.WriteLine($"\n count types {countTypes} \n");

            //count all
            var countAll = (from se in theCars
                            select se.Count).Sum();

            Console.WriteLine($"\n countAll {countAll} \n");
            
            //average price
            var averagePrice = (from se in theCars
                                select se.Price).Average();

            Console.WriteLine($"\n averagePrice {averagePrice} \n");

            //average price type
            // TO DO console input for Brand
            var averagePriceType =
                (from se in theCars
                 where se.Brand == "Volvo"
                 select se.Price).Average();

            Console.WriteLine($"\n averagePriceType Volvo {averagePriceType} \n");
        }

    }
}
