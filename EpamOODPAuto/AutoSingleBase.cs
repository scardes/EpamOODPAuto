using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Singleton class of Auto Database LINQ and logic with LINQ
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

        // Class have List of Car + user add new car by console and logic for commands
        public void singeletonLogic()
        {
            string? brand = string.Empty;
            string? model = string.Empty;
            string? userCommand = string.Empty;
            string? userBrand = string.Empty;
            int count;
            int price;

            bool correctInput = false;

            var theCars = new List<Cars>();

            theCars = new List<Cars>()
                {
                    new Cars() { Brand = "Volvo", Model = "VC300", Count = 10, Price = 80000},
                    new Cars() { Brand = "Volvo", Model = "A777", Count = 5, Price = 20000 },
                    new Cars() { Brand = "Mersedes", Model = "S500", Count = 2, Price = 770000},
                    new Cars() { Brand = "Honda", Model = "Civic", Count = 33, Price = 20000}
                };

            while (!correctInput)
            {
                try
                {
                    Console.WriteLine("Please enter information about cars: 1=brand, 2=model, 3=count, 4=price for one car");
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

            // Start logic for user commands
            Console.WriteLine("\nGive me a command: \n" +
                "1:count types \n" +
                "2:count all \n" +
                "3:average price \n" +
                "4:average price type \n");

            userCommand = Console.ReadLine();

            switch (userCommand)
            {
                //count types
                case "1":
                    var countTypes = (from se in theCars
                                      select se).Count();

                    Console.WriteLine($"\nCount types {countTypes} \n");
                    break;
                //count all
                case "2":
                    var countAll = (from se in theCars
                                    select se.Count).Sum();

                    Console.WriteLine($"\nCountAll {countAll} \n");
                    break;
                //average price
                case "3":
                    var averagePrice = (from se in theCars
                                        select se.Price).Average();

                    Console.WriteLine($"\nAveragePrice {averagePrice} \n");
                    break;
                //average price for user console type = Brand
                case "4":
                    Console.WriteLine("Please enter the cars Type \n");
                    userBrand = Console.ReadLine();
                    
                    try
                    {
                        var averagePriceType = (from se in theCars
                                                where se.Brand == userBrand
                                                select se.Price).Average();

                        Console.WriteLine($"\nAveragePriceType {userBrand} : {averagePriceType} \n");
                    }
                    catch
                    {
                        Console.WriteLine("Please enter correct cars Type \n");
                    }
                    break;
                //Return text for an incorrect option entry.
                default:
                    Console.WriteLine("Command ERROR\n");
                    break;
            }
        }
    }
}
