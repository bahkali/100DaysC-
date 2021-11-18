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

            Console.WriteLine("\n\n");
            // Part 3 Leap Year
            Console.WriteLine("Leap Year");
            Console.Write("Enter an year to determine if it is a leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0) 
            {
                Console.WriteLine("The year {0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not a leap year.", year);
            }

            Console.WriteLine("\n\n");
            // Part 4 Pizza Order
            Console.WriteLine("Pizza Order");

            Console.WriteLine("Welcome to C-sharp Pizza Deliveries!");

            Console.WriteLine("Small Pizza: $15");
            Console.WriteLine("Medium Pizza: $20");
            Console.WriteLine("Large Pizza: $25");
            Console.WriteLine("Pepperoni for Small Pizza: +$2");
            Console.WriteLine("Pepperoni for Medium or Large Pizza: +$3");
            Console.WriteLine("Extra cheese for any size pizza: + $1");
            Console.WriteLine("\n\n");
            // Get the size
            Console.Write("What size pizza do you want? S, M, or L ");
            string size = Console.ReadLine();
            Console.Write("Do you want pepperoni? Y or N ");
            string addPepperoni = Console.ReadLine();
            Console.Write("Do you want extra cheese? Y or N ");
            string extraCheese = Console.ReadLine();

            int finalBill = 0;

            if (size == "S")
            {
                finalBill += 15;
            } 
            else if (size == "M")
            {
                finalBill += 20;
            }
            else 
            {
                finalBill += 25;
            }
            
            if(addPepperoni == "Y" && size == "S")
            {
                finalBill += 2;
            }else{
                // for medium and large
                finalBill += 3;
            }

            if (extraCheese == "Y")
            {
                finalBill += 1;
            }

            Console.WriteLine($"Your final bill is: ${finalBill}");


            Console.ReadKey();
        }
    }
}
