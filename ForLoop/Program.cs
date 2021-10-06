using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i = i + 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"row {i}: ");
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(j); 
                }
                Console.WriteLine();
            }
        }
    }
}
