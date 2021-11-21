using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3] 
            {
                { '.', '.', '.'},
                { '.', '.', '.'},
                { '.', '.', '.'}
            };
            

            Random rand = new Random();
            int userTrun;

            printBoard(board);
            
            while (true)
            {
                
                Console.WriteLine("Please enter a number from 1 to 9");
                userTrun = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed {0}", userTrun);
                int row;
                int col;
                selectBox(userTrun, out row, out col);
                board[row, col] = 'X'; 

                //Computer Chose
                int ConputerTurn = rand.Next(9);
                Console.WriteLine("Computer choose {0}", ConputerTurn);
                selectBox(ConputerTurn, out row, out col);
                board[row, col] = 'O'; 
                printBoard(board);
            }
            
            Console.ReadKey();
        }

        // Print the board in Grid
        static void printBoard(char[,] board)
        {
            int rowCol = 3;
            for(int row = 0; row < rowCol; row++)
            {

                Console.Write("[");
                for (int col = 0; col < rowCol; col++)
                {
                    Console.Write($" {board[row, col]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }

        // Select the grid location with one input
        static void selectBox(int input ,out int row, out int col)
        {

            if (input == 1)
            {
                row = 0;
                col = 0;
            }
            else if (input == 2)
            {
                row = 0;
                col = 1;
            }
            else if (input == 3)
            {
                row = 0;
                col = 2;
            }
            else if (input == 4)
            {
                row = 1;
                col = 0;
            }
            else if (input == 5)
            {
                row = 1;
                col = 1;
            }
            else if (input == 6)
            {
                row = 1;
                col = 2;
            }
            else if (input == 7)
            {
                row = 2;
                col = 0;
            }
            else if (input == 8)
            {
                row = 2;
                col = 1;
            }
            else if (input == 9)
            {
                row = 2;
                col = 2;
            }
            else
            {
                row = 0;
                col = 0;
            }
        }
        
    }
}
