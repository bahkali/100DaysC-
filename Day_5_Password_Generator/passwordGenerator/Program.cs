using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            var text = @"
                                .-""-.
                               / .--. \
                              / /    \ \
                              | |    | |
                              | |.-""-.|
                             ///`.::::.`\
                            ||| ::/  \:: ;
                            ||; ::\__/:: ;
                             \\\ '::::' /
                               `=':-..-'`
                    ";



            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 
                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] symbols = { '!', '#', '$', '%', '&', '(', ')', '*', '+' };
            Console.WriteLine(text);
            Console.WriteLine("Welcome to the SharpPassword Generator!");
            // Get the number of letter  
            try
            {
                Console.Write("How many letters would you like in your passwords? ");
                int n_letters = Convert.ToInt32(Console.ReadLine());

                // Get the number of symbols
                Console.Write("How many symbols would you like? ");
                int n_symbols = Convert.ToInt32(Console.ReadLine());

                // Get the number of numbers
                Console.Write("How many numbers would you like? ");
                int n_numbers = Convert.ToInt32(Console.ReadLine());
            

           Console.Write("Type Hard or Easy for the level of the password: ");
           string str = Console.ReadLine();

            // password string
            StringBuilder passwords = new StringBuilder();
            int randomNumber = 0;

            // Building the Password
            for (int i = 0; i < n_letters; i++)
            {
                randomNumber = rand.Next(letters.Length);
                passwords.Append(letters[randomNumber]);
            }
            for (int i = 0; i < n_symbols; i++)
            {
                randomNumber = rand.Next(symbols.Length);
                passwords.Append(symbols[randomNumber]);
            }
            for (int i = 0; i < n_numbers; i++)
            {
                randomNumber = rand.Next(numbers.Length);
                passwords.Append(numbers[randomNumber]);
            }

            // Eazy Level - Order not randomised:
            // e.g. 4 letter, 2 symbol, 2 number = JduE&!91

            Console.WriteLine("Original password: {0}", passwords.ToString());

            if (str.ToLower() == "hard") {
                // Hard Level - Order of characters randomised:
                // e.g. 4 letter, 2 symbol, 2 number = g^2jk8&P

                for (int i = 0; i < passwords.Length; i++)
                {
                    randomNumber = rand.Next(passwords.Length);
                    char temp = passwords[i];
                    passwords[i] = passwords[randomNumber];
                    passwords[randomNumber] = passwords[i];
                }
                Console.WriteLine("Permuated password: {0}", passwords.ToString());
            }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a number.");
            }

            //End Program
            Console.ReadKey();
        }
    }
}
