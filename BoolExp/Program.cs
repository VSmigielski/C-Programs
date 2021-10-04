using System;

namespace BoolExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int apples = 18;
            int oranges = 9;

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
        }
    }
}
