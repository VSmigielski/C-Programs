using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            bool check = (x != y == !(x == y));

            x = 12;

            x += 34;
            Console.WriteLine(x);

            x -= 34;
            Console.WriteLine(x);

            x *= 34;
            Console.WriteLine(x);

            y = 12;
            y = y * 34;
            Console.WriteLine(y);

            int z = y -= 8;
            Console.WriteLine($"y is {y}, z is {z}");

            double a = 1 + 3 * 15 / 2;
            double b = 1 + 3 * 15 / 2.0;
            Console.WriteLine($"{a}, {b}");

        }
    }
}
