using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogic
{
    public class Board
    {
        public Board()
        {
            //Initialize the Grid.
            Grid = new char[3, 3]
            {
                { '.', '.', '.'},
                { '.', '.', '.'},
                { '.', '.', '.'}
            };
        }

        public char[,] Grid { get; set; }

        // Check if Grid is Full
        public bool isGridFull()
        {
            bool isFull = true;
            //Loop through array
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    if (Grid[i, j] == '.')
                    {
                        isFull = false;
                    }   
                }
            }
            return isFull;
        }

        // Print the Grid in Grid
        public void printGrid()
        {
            int rowCol = 3;
            for (int row = 0; row < rowCol; row++)
            {

                Console.Write("[");
                for (int col = 0; col < rowCol; col++)
                {
                    Console.Write($" {Grid[row, col]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }

        // Select the grid location with one input
        public void selectBox(int input, out int row, out int col)
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

        public char CheckForWinner()
        {
            //return . if nobody won, return the player number if they won.
            //Row
            {
                //top row
                if (Grid[0, 0] == Grid[0, 1] && Grid[0, 1] == Grid[0, 2])
                {
                    return Grid[0, 0];
                }
                //second row
                if (Grid[1, 0] == Grid[1, 1] && Grid[1, 1] == Grid[1, 2])
                {
                    return Grid[1, 0];
                }
                //third row
                if (Grid[2, 0] == Grid[2, 1] && Grid[2, 1] == Grid[2, 2])
                {
                    return Grid[2, 0];
                }
            }
            //Column
            {
                //First Column
                if (Grid[0, 0] == Grid[1, 0] && Grid[1, 0] == Grid[2, 0])
                {
                    return Grid[0, 0];
                }
                //Second Column
                if (Grid[0, 1] == Grid[1, 1] && Grid[1, 1] == Grid[2, 1])
                {
                    return Grid[0, 1];
                }
                //Third Column
                if (Grid[0, 2] == Grid[1, 2] && Grid[1, 2] == Grid[2, 2])
                {
                    return Grid[0, 2];
                }
            }
            //Diagonal
            {
                //right
                if (Grid[0, 0] == Grid[1, 1] && Grid[1, 1] == Grid[2, 2])
                {
                    return Grid[0, 0];
                }
                //left
                if (Grid[0, 2] == Grid[1, 1] && Grid[1, 1] == Grid[2, 0])
                {
                    return Grid[0, 2];
                }
            }
            return '.';
        }
    }
}
