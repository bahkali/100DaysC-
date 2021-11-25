﻿using System;
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
            

            Console.WriteLine("\tType 'encode' to encrypt, type 'decode' to decrypt: ");
            string direction = Console.ReadLine().ToLower();

            Console.WriteLine("Type your message: ");
            string text = Console.ReadLine().ToLower();

            Console.Write("Type the shift number: ");
            int shift = Convert.ToInt32(Console.ReadLine());

            if(direction == "encrypt") { encrypt(text, shift); }
            else if (direction == "decode") { Console.WriteLine("Still working on it..."); }

            //End Program
            Console.Read();
        }

        static void encrypt(string text, int shift) 
        {
            StringBuilder word = new StringBuilder();
            foreach(char c in text)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if(alphabet[i] == c)
                    {
                        word.Append(alphabet[i + shift]);
                    }
                }
            }

            Console.WriteLine("The encoded text is {0}", word.ToString());
        }
    }
}
