using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int answer = 7 + 3 * 4;
            Console.WriteLine(answer);

            double radius = 12;
            double area = Math.PI * radius * radius;*/

            int x = 3;
            // int y = x++;
            int y = x;
            x++;

            Console.WriteLine($"Using x++, x is {x} and y is {y}");
            // Using x++, x is 4 and y is 3

            x = 3;
            // y = ++x;
            x++;
            y = x;

            Console.WriteLine($"Using x++, x is {x} and y is {y}");
            // Using ++x, x is 4 and y is 4

            Console.WriteLine("Don't do this!");

            x = 3;
            // y = ++x - x++;
            x++;
            int z = x;
            y = z - x;
            x++;

            Console.WriteLine($"++x - x++ gives: x is {x} and y is {y}");
            // ++x - x++ gives: x is 5 and y is 0

            x = 3;
            // y = ++x - ++x;
            z = x;
            x += 2;
            y = z - x;

            Console.WriteLine($"++x - ++x gives: x is {x} and y is {y}");
            //++x - ++x gives: x is 5 and y is -2

            double a = 12 * 3 / 4.0;
            double b = (12 * 3) / 4.0;
            // If the value is 4, not 4.0, the value is 0
            double c = 12 * (3 / 4);

            Console.WriteLine($"{a}, {b}, {c}");

            double d = 12.0 / 3.0 / 4.0;
            double e = (12.0 / 3.0) / 4.0;
            double f = 12.0 / (3.0 / 4.0);

            Console.WriteLine($"{d}, {e}, {f}");

            int g = 12 + 3 - 4;
            int h = (12 + 3) - 4;
            int i = 12 + (3 - 4);

            Console.WriteLine($"{g}, {h}, {i}");

            int j = 12 + 3 * 4;
            int k = (12 + 3) * 4;
            int l = 12 + (3 * 4);

            Console.WriteLine($"{j}, {k}, {l}");
        }
    }
}
