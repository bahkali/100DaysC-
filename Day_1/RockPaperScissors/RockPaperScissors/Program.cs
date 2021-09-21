using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    break;
                case 2:
                    inputCPU = "PAPER";
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
        }
    }
}
