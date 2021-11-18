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

            Console.WriteLine("\n\n");

            // Part 2 BMI calculator
            Console.WriteLine("2. BMI Calculator 2");
            Console.Write("Enter your height in m: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter you weight in kg: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Calculate BMI 
            double bmi = weight / Math.Pow(height, 2);
            //Console.WriteLine("Your BMI is {0}", Math.Round(bmi));
            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {Math.Round(bmi)}, you are underweight.");
            } else if ( bmi < 25)
            {
                Console.WriteLine($"Your BMI is {Math.Round(bmi)}, you have a normal weight.");
            } else if (  bmi < 30)
            {
                Console.WriteLine($"Your BMI is {Math.Round(bmi)}, you are slightly overweight.");
            } else if ( bmi < 35)
            {
                Console.WriteLine($"Your BMI is {Math.Round(bmi)}, you are obese.");
            } else
            {
                Console.WriteLine($"Your BMI is {Math.Round(bmi)}, you are clinically obese.");
            }


            Console.ReadKey();
        }
    }
}
