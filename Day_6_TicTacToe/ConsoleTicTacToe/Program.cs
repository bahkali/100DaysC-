using BoardLogic;
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
            /*
            char[,] board = new char[3, 3] 
            {
                { '.', '.', '.'},
                { '.', '.', '.'},
                { '.', '.', '.'}
            };*/

            Board game = new Board();

            Random rand = new Random();
            int ConputerTurn = -1;
            int userTrun = -1;
            int row = 0;
            int col = 0;

            game.printGrid();
            
            while (game.CheckForWinner() == '.')
            {
                // don't allow the human to choose an already occupied grid
                while(userTrun == -1 || game.Grid[row, col] != '.')
                {
                    Console.WriteLine("Please enter a number from 1 to 9");
                    userTrun = int.Parse(Console.ReadLine());
                    Console.WriteLine("You typed {0}", userTrun);
                    game.selectBox(userTrun, out row, out col);

                }
                // add
                game.Grid[row, col] = 'X';
                // Check grid if full
                if (game.isGridFull()) { break; }

                // Don't allow the computer to pick an invalid number
                while (ConputerTurn == -1 || game.Grid[row, col] != '.')
                {
                    //Computer Chose
                    ConputerTurn = rand.Next(9);
                    Console.WriteLine("Computer choose {0}", ConputerTurn);
                    game.selectBox(ConputerTurn, out row, out col);
                }
                
                game.Grid[row, col] = 'O';
                // Check grid if full
                if (game.isGridFull()) { break; }

                //Print the board
                game.printGrid();
            }

            //Print the Winner
            Console.WriteLine("{0} won the game.", game.CheckForWinner() == 'X'? "You":"Computer" );

            Console.ReadKey();
        }

        /*
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
        private static char CheckForWinner(char[,] board)
        {
            //return . if nobody won, return the player number if they won.
            //Row
            {
                //top row
                if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
                {
                    return board[0, 0];
                }
                //second row
                if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
                {
                    return board[1, 0];
                }
                //third row
                if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
                {
                    return board[2, 0];
                }
            }
            //Column
            {
                //First Column
                if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
                {
                    return board[0, 0];
                }
                //Second Column
                if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
                {
                    return board[0, 1];
                }
                //Third Column
                if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
                {
                    return board[0, 2];
                }
            }
            //Diagonal
            {
                //right
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    return board[0, 0];
                }
                //left
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return board[0, 2];
                }
            }
            return '.';
        }
        */
    }
}
