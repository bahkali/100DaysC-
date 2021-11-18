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
            /*
            Console.WriteLine("Banker Roulette");
            Console.WriteLine("Give me everybody's names, separated by a comma.");
            string[] names = Console.ReadLine().Split(',');
            int randName = rand.Next(0, names.Length + 1);
            Console.WriteLine($"{names[randName].Trim(' ')} is going to buy the meal today!");
            */

            // Exercise 3 - Treasure map
            Console.WriteLine("Treasure Map");
            const int rows = 3;
            const int cols = 3;
            //char c = Convert.ToChar(141);

            string[,] map = new string[rows,cols] 
            {
                {"□","□","□"},
                {"□","□","□"},
                {"□","□","□"}
            };

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*for (int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", map[row, col]);
                }
                Console.WriteLine();
            }*/

            printGrid(map);
            try
            {
                Console.Write("Enter two digit between 1 to 3 to place a X," +
                    " \nfirst digit is the column and second is the row: ");
                string input = Console.ReadLine();
                
                int c = (int)Char.GetNumericValue(input[0]);
                int r = (int)Char.GetNumericValue(input[1]);
                Console.WriteLine($"col = {c -1} row = {r -1}");
                map[r -1, c -1] = "X";
                printGrid(map);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // End Program
            Console.ReadKey();
        }

        static void printGrid(string[,] map, int rows=3, int cols=3)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", map[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
