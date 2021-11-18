using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 Odd or Even
            Console.WriteLine("1. Odd or Even exercise");
            Console.Write("Please enter a number to check if even or odd? ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This is an even number.");
            }
            else
            {
                Console.WriteLine("This is an odd number.");
            }

            Console.ReadKey();
        }
    }
}
