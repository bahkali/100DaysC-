using BoardLogic;
using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacGUI
{
    public partial class Form1 : Form
    {
        Board game = new Board();
        Button[] buttons = new Button[9];
        Random rand = new Random();
        int row = 0;
        int col = 0;

        SoundPlayer winningSound = new SoundPlayer(@"C:\Users\PrecisionM4800\Desktop\100DaysC#\Day_6_TicTacToe\TicTacGUI\media\winGame.mp3");

        public Form1()
        {
            InitializeComponent();
            game = new Board();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i + 1;

            }
        }

        private void handleButtonclick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button clickedButton = (Button)sender;
            //MessageBox.Show("button " + clickedButton.Tag + " was clicked");
            int gameSquareNumber = (int)clickedButton.Tag;
            

            game.selectBox(gameSquareNumber,out row, out col);
            game.Grid[row, col] = 'X';

            updateBoard();

            //Check if Board full
            if(game.isGridFull() == true)
            {
                MessageBox.Show("The board is full");
                disableAllButtons();
            }else if (game.CheckForWinner() == 'X')
            {
                //winningSound.Play();
                MessageBox.Show("You won!!");
                disableAllButtons();
            }
            else
            {
                // Computer Turn
                computerChoose();
            }

            
        }

        private void disableAllButtons()
        {
            foreach(var item in buttons)
            {
                item.Enabled = false;
            }
        }

        private void computerChoose()
        {
            int computerTurn = rand.Next(9);
            while (computerTurn == -1 || game.Grid[row, col] != '.')
            {
                //Computer Chose
                computerTurn = rand.Next(9);
                Console.WriteLine("Computer choose {0}", computerTurn);
                game.selectBox(computerTurn, out row, out col);
            }
            game.Grid[row, col] = 'O';
            updateBoard();

            //check for winner
            if(game.CheckForWinner() == 'O')
            {
                //winningSound.Play();
                MessageBox.Show("Computer win!!");
                disableAllButtons();
            }
            else if (game.isGridFull() == true)
            {
                MessageBox.Show("The board is full");
                disableAllButtons();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            int count = 0;
            //Loop through array
            for (int i = 0; i < game.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < game.Grid.GetLength(1); j++)
                {
                    if (game.Grid[i, j] == '.')
                    {
                        buttons[count].Text = "";
                        buttons[count].Enabled = true;
                    }
                    else if(game.Grid[i, j] == 'X')
                    {
                        //buttons[count].Text = "X";
                        buttons[count].Image = Image.FromFile("C:\\Users\\PrecisionM4800\\Desktop\\100DaysC#\\Day_6_TicTacToe\\TicTacGUI\\images\\x.png");
                        buttons[count].ImageAlign = ContentAlignment.MiddleCenter;
                        //buttons[count].Enabled = false;
                    }
                    else if (game.Grid[i, j] == 'O')
                    {
                        //buttons[count].Text = "O";
                        buttons[count].Image = Image.FromFile("C:\\Users\\PrecisionM4800\\Desktop\\100DaysC#\\Day_6_TicTacToe\\TicTacGUI\\images\\o.png");
                        buttons[count].ImageAlign = ContentAlignment.MiddleCenter;
                        //buttons[count].Enabled = false;
                    }
                    count++;
                }
            };

        }

        private void button10_Click(object sender, EventArgs e)
        {
            game = new Board();
            enableAllButtons();
        }

        private void enableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = true;
                item.Image = null;
            }
            updateBoard();
        }
    }
}
