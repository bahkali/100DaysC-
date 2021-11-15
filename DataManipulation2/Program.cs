using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------- Day 2 - Practice ----
            // Data Types
            Console.Write("Type two digit number to add up: ");
            // get the two digit
            string number = Console.ReadLine();
            // Extra each number and convert Character to Int
            int x = (int)Char.GetNumericValue(number[0]);
            int y =(int)Char.GetNumericValue(number[1]);
            // Output the sum of the number
            Console.WriteLine($"The output of {x} + {y} = {x + y}");

            // -- BMI calculator 

            Console.WriteLine("Calculate your BMI");
            Console.Write("Enter your height in meter: ");
            double height = Convert.ToDouble(Console.ReadLine());
 
            Console.Write("Enter you weight in Kg: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Calculate the BMI
            double bmi = weight / Math.Pow(height, 2);
            
            Console.WriteLine($"Your bmi is {Convert.ToInt32(bmi)}");



            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();

        }
    }
}
