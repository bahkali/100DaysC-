using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecrectAuction
{
    class Program
    {
        static void Main(string[] args)
        {
            var logo = @"

                         ___________
                         \         /
                          )_______(
                          |""""""""""""""|_.-._,.---------.,_.-._
                          |       | | |               | | ''-.
                          |       |_| |_             _| |_..-'
                          |_______| '-' `'---------'` '-'
                          )""""""""""""""(
                         /_________\\
                       .-------------.
                      /_______________\\

";
            Console.WriteLine(logo);
            Console.WriteLine("Welcome to the secret auction program");
            string bidDecision;
            Dictionary<string, int> players = new Dictionary<string, int>();
            do
            {
                Console.Write("What is you name? ");
                string playerName = Console.ReadLine();
                Console.Write("What is your bid? ");
                int playerBid = Convert.ToInt32(Console.ReadLine());

                players.Add(playerName, playerBid);

                Console.WriteLine("Are there any other bidders? Type 'yes' or 'no'.");
                bidDecision = Console.ReadLine();
                Console.Clear();
            }while (bidDecision == "yes") ;

            var val = players.Values.Max();
            var winner = players.First(e => e.Value == val);
            Console.WriteLine($"The winner is {winner.Key} with a bid of ${winner.Value}");

            //End program
            Console.Read();
        }
    }
}
