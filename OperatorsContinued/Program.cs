using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 12;
            int y = 3;

            if (x % y == 0)
            {
                Console.WriteLine($"{y} divides exactly into {x}");
            } 
            else
            {
                Console.WriteLine($"{y} does not divide exactly into {x}");
            }*/

            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine($"The next month after {month} is {month % 12 + 1}");
            }

            int second = 31;
            int minute = 1;

            if ((minute < 59) && ((second + 1) > 59))
            {
                minute++;
            }

            int a = 12;
            // If b is 0 then it gives an error
            int b = 6;

            /*if (b != 0)
            {
                int c = DivideTwoNumbers(a, b);

                if (c == 2)
                {
                    Console.WriteLine("We've found a 2");
                }
            }*/

            // Helps avoid null pointer exceptions
            if (b != 0 && DivideTwoNumbers(a, b) == 2)
            {
                Console.WriteLine("We've found a 2");
            }

            if (b == 0 || DivideTwoNumbers(a, b) == 2)
            {
                Console.WriteLine("We've found a 2");
            }

        }

        static int DivideTwoNumbers(int x, int y)
        {
            return x / y;
        }
    }
}
