using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the bill was $150.00, split between 5 people, with 12% tip.
            //Each person should pay (150.00 / 5) * 1.12 = 33.6
            //Format the result to 2 decimal places = 33.60
            //Tip: There are 2 ways to round a number. You might have to do some Googling to solve this.💪
            //Write your code below this line 👇


            Console.WriteLine("Welcome to the tip Calculator!");
            // Get the bill amount
            Console.Write("What was the total bill? ");
            double bill = Convert.ToDouble(Console.ReadLine());
            // Get the tip percentage
            Console.Write("How much tip would you like to give? 10, 12 or 15? ");
            int tip = Convert.ToInt32(Console.ReadLine());
            // Number of people spliting the bills
            Console.Write("How many people to split the bill? ");
            int split = Convert.ToInt32(Console.ReadLine());

            double totalBill = (bill * tip / 100)+ bill;
            double totalEach = totalBill / split;
            Console.WriteLine("Each person should pay: ${0}", Math.Round(totalEach, 2));

            Console.ReadKey();
        }
    }
}
