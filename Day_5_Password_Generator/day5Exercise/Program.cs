using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 - Average Height

            Console.WriteLine("Average Height");
            Console.Write("Input a list of student heights separated by space: ");
            // Get the data and split it
            string[] inputs = Console.ReadLine().Split(' ');
            List<int> student_heights = new List<int>();
            // Convert item to int
            foreach (string s in inputs)
            {
                student_heights.Add(Convert.ToInt32(s)) ;
            }

            int total_heights = student_heights.Sum();
            int average_heights = total_heights / student_heights.Count;
            Console.WriteLine($"The average height is {average_heights}.");

            // Exercise 2 - High Score


            // Exercise 3 - Adding Even Numbers


            // Exercise 4 -  FizzBuzz Job

            // End of Program
            Console.ReadKey();
        }
    }
}
