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
            /*
            Console.WriteLine(" Average Height ");
            Console.WriteLine("================");
            Console.Write("Input a list of student heights separated by space: ");
            // Get the data and split it
            string[] inputs = Console.ReadLine().Split(' ');
            List<int> student_heights = new List<int>();
            // Convert item to int
            foreach (string s in inputs)
            {
                student_heights.Add(Convert.ToInt32(s)) ;
            }
            // calculate the total and average of heights
            int total_heights = student_heights.Sum();
            int average_heights = total_heights / student_heights.Count;
            Console.WriteLine($"The average height is {average_heights}.");
            */
            // Exercise 2 - High Score
            /*
            Console.WriteLine("   High Score ");
            Console.WriteLine("================");
            Console.Write("Input a list of student score separated by space: ");
            // Get the data and split it
            string[] inputs = Console.ReadLine().Split(' ');
            List<int> student_score = new List<int>();
            // Convert item to int
            foreach (string s in inputs)
            {
                student_score.Add(Convert.ToInt32(s));
            }
            //int maxNumber = student_score.Max();
            int maxNumber = 0;
            foreach(int i in student_score)
            {
                if(maxNumber < i)
                {
                    maxNumber = i;
                }
            }
            Console.WriteLine($"The highest score in the class is: {maxNumber}");
            */

            // Exercise 3 - Adding Even Numbers
            /*
            Console.WriteLine(" Adding Even Numbers ");
            Console.WriteLine("=====================");
            IEnumerable<int> num = Enumerable.Range(0, 100).Select(x => x + 1);
            //Array.ForEach(num, Console.WriteLine);
            int sum = 0;
            //List<int> evenNumber = new List<int>();
            foreach (int i in num)
            {
                //Console.Write(i + " ");
                if(i % 2 == 0)
                {
                    //evenNumber.Add(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The final total is {sum}");
            */
            // Exercise 4 -  FizzBuzz Job
            Console.WriteLine(" FizzBuzz Game ");
            Console.WriteLine("===============");
            IEnumerable<int> count100 = Enumerable.Range(0, 100).Select(x => x + 1);
            foreach(int i in count100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if( i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if ( i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else
                {
                    Console.WriteLine(i);
                }
            }
            // End of Program
            Console.ReadKey();
        }
    }
}
