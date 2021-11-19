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
            
           

            var rock = @"
                        _______
                    ---'   ____)
                          (_____)
                          (_____)
                          (____)
                    ---.__(___)
                    ";
            var paper = @"
                        _______
                    ---'   ____)____
                              ______)
                              _______)
                             _______)
                    ---.__________)
                    ";
            var scissors = @"
                        _______
                    ---'   ____)____
                              ______)
                           __________)
                          (____)
                    ---.__(___)
                    ";
            string[] games = { rock, paper, scissors };
            Random rnd = new Random();
            string str;
            Console.WriteLine("Rock-Paper-Scissors Game:");
            do {
                Console.Write("Choose between 0 for ROCK, 1 for PAPER and 2 for SCISSORS: ");

                int inputPlayer = Convert.ToInt32(Console.ReadLine());
                if (inputPlayer >= 3 || inputPlayer < 0)
                {
                    Console.WriteLine("You type an invalid number.");
                }
                else
                {
                    Console.WriteLine(games[inputPlayer]);
                    // Computer generated choose
                    int computerChoose = rnd.Next(0, 3);
                    Console.WriteLine($"Computer chose {computerChoose}");
                    Console.WriteLine(games[computerChoose]);


                    if (inputPlayer == 0 && computerChoose == 2)
                    {
                        Console.WriteLine("You win.!");
                    }
                    else if (computerChoose == 0 && inputPlayer == 2)
                    {
                        Console.WriteLine("You lose");
                    }
                    else if (computerChoose > inputPlayer)
                    {
                        Console.WriteLine("You lose");
                    }
                    else if (computerChoose < inputPlayer)
                    {
                        Console.WriteLine("You win");
                    }
                    else if (computerChoose == inputPlayer)
                    {
                        Console.WriteLine("It's a draw");
                    }
                }
                Console.Write("Type exit to stop the game or enter to continue: ");
                str = Console.ReadLine().ToLower();
            } while (str != "exit");

        }
    }
}
