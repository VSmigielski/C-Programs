using System;

namespace ElizaIsSilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Doctor.Intro());

            // Used to hold user input
            var userInput = "";

            // If user input is not "quit", continue running the code
            while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                // Reads the input within console
                userInput = Console.ReadLine();
                string response = Doctor.response(userInput);
                Console.WriteLine(response);
            }
            


        }
    }
}
