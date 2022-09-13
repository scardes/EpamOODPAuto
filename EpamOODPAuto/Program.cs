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




                // Wait for the user to respond before closing.
                Console.Write("Enter 'exit' to close the app, or press any key and Enter to continue: ");

                if (Console.ReadLine() == "exit")
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Friendly linespacing
            }
        }
    }
}
