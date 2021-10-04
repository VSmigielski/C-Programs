using System;

namespace BoolExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int apples = 6;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;

            // Value is false 
            // Double equals (==) checks if two things are equal to one another
            Console.WriteLine(apples == oranges);
            // True
            // != Not equals
            Console.WriteLine(apples != oranges);

            // True
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");

            // False
            Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");

            // True
            Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");

            // False
            Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");

            // True
            Console.WriteLine($"{apples} is int is {apples is int}");

            // Two conditions And Check
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) && (applePrice > orangePrice)}");

            // Two conditions Either/or Check
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) || (applePrice > orangePrice)}");


            bool moreApples;
            bool applesAreDearer;

            moreApples = (apples > oranges);
            applesAreDearer = (applePrice > orangePrice);

            Console.WriteLine($"We have more apples: {moreApples}");
            Console.WriteLine($"Apples are dearer: {applesAreDearer}");

            Console.WriteLine($"Reducing apple cost: {moreApples && applesAreDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApples || applesAreDearer}");

            bool moreApplesAndDearer = moreApples && applesAreDearer;
            bool moreApplesOrDearer = moreApples || applesAreDearer;

            Console.WriteLine($"Reducing apple cost: {moreApplesAndDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApplesOrDearer}");

        }
    }
}
