using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q- Quit the program");

            // while (!userChoice.Equals('q'))
            // while ((!userChoice.Equals('q')) || (!userChoice.Equals('Q')))

            do
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose " + userChoice);
            
                switch (userChoice)
                {
                    case '1':
                    case '2':
                        Console.WriteLine("Making Latte...");
                        Console.WriteLine("Make espresso");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Add milk to the espresso");
                        // Breaks out of switch
                        break;
                    case '3':
                        Console.WriteLine("Making Americano...");
                        // Breaks out of switch
                        break;
                    case '4':
                        Console.WriteLine("Making Mocha...");
                        // Breaks out of switch
                        break;
                    case '5':
                        Console.WriteLine("Making Macchiatto...");
                        // Breaks out of switch
                        break;
                    case '6':
                        Console.WriteLine("Making Espresso...");
                        // Breaks out of switch
                        break;
                    default:
                        Console.WriteLine("Returning coins");
                        // Skips to line 66, code on 63&64 will not be executed
                        continue;
                }

                // This would break out of the do while loop
                // break;

                Console.WriteLine("Dispensing coffee");
                Console.WriteLine("Have a nice day");
            
            } while (!userChoice.Equals('q'));


        }
    }
}
