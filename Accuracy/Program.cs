using System;

namespace Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double result1 = 0.1 * 7;
            double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;

            Console.WriteLine($"1st result is {result1}");
            Console.WriteLine($"2nd result is {result2}");

            double difference = result1 - result2;
            // The answer is not 0 exactly, close to 0 though
            Console.WriteLine($"The difference is {difference:R}");

            Console.WriteLine();
            Console.WriteLine("Decimals");

            decimal result3 = 0.1m * 7m;
            decimal result4 = 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m;

            Console.WriteLine($"1st result is {result3}");
            Console.WriteLine($"2nd result is {result4}");

            decimal difference2 = result3 - result4;
            // The answer is not 0 exactly, close to 0 though
            Console.WriteLine($"The difference is {difference2}");

            bool checkResult = result1 - result2 == 0;

        }
    }
}
