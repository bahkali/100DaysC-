using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            // Exercise 1 - Heads and Tails
            /*
            Console.WriteLine("Heads and Tails games");
            Console.WriteLine("Every time you run the program it will randomly choose between head and tail.");
            
            int randNumber= rand.Next(0, 2);
            if (randNumber == 1)
            {
                Console.WriteLine("Heads");
            } else {Console.WriteLine("Tails");}

            */
            // Exercise 2 - Banker Roulette


            Console.WriteLine("Banker Roulette");
            Console.WriteLine("Give me everybody's names, separated by a comma.");
            string[] names = Console.ReadLine().Split(',');
            
      
            int randName = rand.Next(0, names.Length + 1);
            Console.WriteLine($"{names[randName].Trim(' ')} is going to buy the meal today!");

            // End Program
            Console.ReadKey();
        }
    }
}
