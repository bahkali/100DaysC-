using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        public static char[] alphabet = new char[] {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        static void Main(string[] args)
        {
            var logo = @"
                                                 ___
                                               ___  '-.
                                   _         ___  '-.  \
                                 _ o\_____ ___  '-.  \  |______
                               _  \  |   ___  '-.  \  |      _/\
                             _ o\    | ___  '-.  \  |      _/ _ |
                            / \      ___  '-.  \  |      _/ _/o\ \
                           | O |   ___  '-.  \  |      _/ _/o   | |
                         _/|   |.-'   '-.  \  |      _/ _/o   o  \ \
                       _/      /         \  |      _/ _/o   o   o | |
                      /_______|           |_____ _/ _/o   o   o _/ _/ === ===
                     |        .-.               |  /o   o   o _/ _/ === === ===
                     |       /-. )_________      \ \  o   o _/ _/ === === ===|
                     |      (   )________  \     | |   o _/ _/ === === ===| |
                     |       \_________   \ )     \ \o _/ _/|=== === ===| |_|
                     |            |    (   )      | |/ _/|__||  ||  || |_|
                     |   .-.      |    |'-'        \ _/|____||__||__||_|
                     |  (   )    _|____|_           |  |     |   |___|
                     |   '-'     \      /           |  |_____|---
                     |            \_____======O=========O/
                     |______________________________|_/
                    ";
            string shouldContinue = "no";
            Console.WriteLine(logo);
            do
            {
                Console.Write(" Type 'encode' to encrypt, type 'decode' to decrypt: ");
                string direction = Console.ReadLine().ToLower();

                Console.Write(" Type your message: ");
                string text = Console.ReadLine().ToLower();

                Console.Write(" Type the shift number: ");
                int shift = Convert.ToInt32(Console.ReadLine());
                

                //if(direction == "encrypt") { encrypt(text, shift); }
                //else if (direction == "decode") { decode(text, shift); }
                //else { Console.WriteLine(" You didn't choose a direction."); }


                caesar(text, shift, direction);
                Console.WriteLine("Type 'yes if you want to go again. Otherwise type 'no': ");
                shouldContinue = Console.ReadLine();
            } while (shouldContinue  == "yes");

            Console.WriteLine("Goodbye.");
            //End Program
            Console.Read();
        }

        static void caesar(string text, int shift, string direction)
        {
            StringBuilder word = new StringBuilder();
            int checkOutBound;
            foreach (char c in text)
            {
                int i = Array.IndexOf(alphabet, c);

                if ( i != -1 && alphabet[i] == c)
                {
                    
                    if (direction == "decode")
                    {
                        //checkOutBound = (i - shift) % alphabet.Length;
                        word.Append(alphabet[i - shift]);
                    }
                    else
                    {
                        checkOutBound = (i + shift) % alphabet.Length;
                        word.Append(alphabet[checkOutBound]);
                    }
                        
                }
                else
                {
                    word.Append(c);
                }
                
            }

            Console.WriteLine($" The {direction}d text is {word.ToString()}");
        }
        //static void encrypt(string text, int shift) 
        //{
        //    StringBuilder word = new StringBuilder();
        //    foreach(char c in text)
        //    {
        //        for (int i = 0; i < alphabet.Length; i++)
        //        {
        //            if(alphabet[i] == c)
        //            {
        //                word.Append(alphabet[i + shift]);
        //            }
        //        }
        //    }

        //    Console.WriteLine(" The encoded text is {0}", word.ToString());
        //}

        //static void decode(string text, int shift)
        //{
        //    StringBuilder word = new StringBuilder();
        //    foreach (char c in text)
        //    {
        //        for (int i = 0; i < alphabet.Length; i++)
        //        {
        //            if (alphabet[i] == c)
        //            {
        //                word.Append(alphabet[i - shift]);
        //            }
        //        }
        //    }

        //    Console.WriteLine(" The decoded text is {0}", word.ToString());
        //}
    }
}
