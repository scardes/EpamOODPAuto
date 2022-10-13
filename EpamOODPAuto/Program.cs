using System;
using System.Collections.Generic;

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

                asb1.businessLogic();

                // Wait for the user to respond before closing.
                Console.Write("\nEnter 'e' to close the app, or press any key and Enter to continue: "); //TODO Change to exit

                if (Console.ReadLine() == "e") //TODO Change to exit
                {
                    endApp = true;
                }
                
                Console.WriteLine("\n"); // Friendly linespacing
            }
        }
    }
}
