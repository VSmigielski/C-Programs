using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            // Variable type first, C# must declare a variable to use it
            // Can use numbers, cannot begin with a number
            // Cannot use keywords as variable names / error: identifier expected
            int firstNumber = randomNumber.Next(2, 10);
            int secondNumber = randomNumber.Next(2, 10);

            // keyword var, not explicitly an int
            // If variable type can be inferred, can use var
            var subtraction = randomNumber.Next(2, 10);

            // No assignment yet because it's not calculated
            int answer ;

            // Store info within a variable rather than typing it multiple times
            string prompt = "Don't type in the answer, just press ENTER when ready";

            Console.WriteLine("Think of a number between 1 and 10" + prompt);
            Console.ReadKey();

            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();

            Console.WriteLine("Now multiply the result by " + secondNumber + prompt);
            Console.ReadKey();

            Console.WriteLine("Divide the result by the number you originally thought of" + prompt);
            Console.ReadKey();

            Console.WriteLine("Now subtract " + subtraction + prompt);
            Console.ReadKey();

            Console.WriteLine("The answer is " + answer);

        }
    }
}
