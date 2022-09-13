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

                AutoSingleBase asb1 = AutoSingleBase.GetAutoBase();
                AutoSingleBase asb2 = AutoSingleBase.GetAutoBase();

                if (asb1 == asb2)
                {
                    Console.WriteLine("Singleton works\n");
                }
                else
                {
                    Console.WriteLine("Singleton failed");
                }


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
