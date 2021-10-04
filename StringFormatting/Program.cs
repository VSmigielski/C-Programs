using System;

// https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting#format-string-component

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string apples = "Apples";
            //int appleQuantity = 8;
            //int applePrice = 100;
            //string oranges = "Oranges";
            //int orangeQuantity = 12;
            //int orangePrice = 80;

            //string column1Heading = "Fruit";
            //string column2Heading = "Quantity";
            //string column3Heading = "Price";

            //// 12, 8, 6 is width in characters 
            //// Negative writes to the left for the names of items
            //// " :C " gives currency
            //// You can use expressions within the {} on variables
            //Console.WriteLine($"{column1Heading, -12} {column2Heading, 8} {column3Heading, 10}");
            //Console.WriteLine($"{apples, -12} {appleQuantity, -8} {applePrice/100.0, 10:C}");
            //Console.WriteLine($"{oranges, -12} {orangeQuantity, -8} {orangePrice/100.0, 10:C}");

            // " :F{number} " is precision
            // Floating point numbers stored within the language only have so much precision
            // This is why the last PI has 0 following up to the end of the format number
            Console.WriteLine($"PI is {Math.PI}");

            Console.WriteLine($"PI is {Math.PI:F3}");
            Console.WriteLine($"PI is {Math.PI:F0}");
            Console.WriteLine($"PI is {Math.PI:F12}");
            Console.WriteLine($"PI is {Math.PI:F99}");
        }
    }
}
