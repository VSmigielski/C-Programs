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
            
        

        }
    }
}
