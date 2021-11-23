using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Step 1
            string[] word_list = { "aardvark", "baboon", "camel" };
            Random rand = new Random();

            //TODO-1 - Randomly choose a word from the word_list and assign it to a variable called chosen_word.
            int randomNumber = rand.Next(word_list.Length);
            string chosen_word = word_list[randomNumber];
            Console.WriteLine(chosen_word);
            //TODO-2 - Ask the user to guess a letter and assign their answer to a variable called guess. Make guess lowercase.
            Console.Write("Guess a letter: ");
            char guess = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine($"You guess {guess}");

            //TODO-3 - Check if the letter the user guessed (guess) is one of the letters in the chosen_word.

            //Console.WriteLine(chosen_word.Contains(guess));
            foreach(char l in chosen_word)
            {
                if (l == guess) Console.Write(guess);
                else Console.Write('_');
            }


            //End Program
            Console.Read();
        }
    }
}
