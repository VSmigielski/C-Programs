using System;

namespace ElizaIsSilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Changing colors of console text
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            Console.WriteLine(Doctor.Intro());

            Console.ResetColor();

            // Used to hold user input
            var userInput = "";

            // If user input is not "quit", continue running the code
            while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                // Reads the input within console
                userInput = Console.ReadLine();
                string response = Doctor.Response(userInput);

                // Changing colors of console text
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(response);
                Console.ResetColor();
            }
            


        }
    }
}
