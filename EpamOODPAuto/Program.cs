using System;

/// <summary>
/// Console program for Object Oriented Design Principles. 
/// Use Singleton and Command
/// </summary>
namespace EpamOODPAuto
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool endApp = false;

            // Repeat program, until user input "exit" to exit.
            while (!endApp)
            {
                string? brand = string.Empty;
                string? model = string.Empty;
                int count;
                int price;

                Console.WriteLine("Please enter information about cars: brand, model, count, price");
                string[] arr = Console.ReadLine().Split();

                brand = arr[0];
                model = arr[1];
                int.TryParse(arr[2], out count);
                int.TryParse(arr[3], out price);

                Console.WriteLine($" brand= {brand},  model= {model} count= {count}, price= {price}");

                AutoSingleBase asb1 = AutoSingleBase.GetAutoBase();
                AutoSingleBase asb2 = AutoSingleBase.GetAutoBase();

                //TODO This just for check (need be deleted)
                if (asb1 == asb2)
                {
                    Console.WriteLine("Singleton works\n");
                }
                else
                {
                    Console.WriteLine("Singleton failed");
                }

                asb1.businessLogic("Send Command");


                // Wait for the user to respond before closing.
                Console.Write("Enter 'e' to close the app, or press any key and Enter to continue: "); //TODO Change to exit

                if (Console.ReadLine() == "e") //TODO Change to exit
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Friendly linespacing
            }
        }
    }
}
