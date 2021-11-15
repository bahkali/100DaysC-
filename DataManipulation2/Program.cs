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
            //Console.Write("Type two digit number to add up: ");
            // get the two digit
            //string number = Console.ReadLine();
            // Extra each number and convert Character to Int
            //int x = (int)Char.GetNumericValue(number[0]);
            //int y =(int)Char.GetNumericValue(number[1]);
            // Output the sum of the number
            //Console.WriteLine($"The output of {x} + {y} = {x + y}");

            // -- BMI calculator 

            //Console.WriteLine("Calculate your BMI");
            //Console.Write("Enter your height in meter: ");
            //double height = Convert.ToDouble(Console.ReadLine());
 
            //.Write("Enter you weight in Kg: ");
            //int weight = Convert.ToInt32(Console.ReadLine());

            //Calculate the BMI
            //double bmi = weight / Math.Pow(height, 2);
            
            //Console.WriteLine($"Your bmi is {Convert.ToInt32(bmi)}");

            // Life in Weeks

            Console.WriteLine("Life in weeks");
            Console.Write("What is you current age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            int days = (90 * 365) - ( age * 365);
            int weeks = (90 * 52 ) - (age * 52);
            int month = (90 * 12) - (age * 12);

            Console.WriteLine($"You have {days} days, {weeks} weeks, {month} months left.");
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();

        }
    }
}
