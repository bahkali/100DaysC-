using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = Console.ReadLine();
            Console.Write("What month were you born in? ");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is {0} you are {1}, and born on {2}", name, age, month);
        }
    }
}
