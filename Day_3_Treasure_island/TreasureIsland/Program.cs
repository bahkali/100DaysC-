using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureIsland
{
    class Program
    {
        static void Main(string[] args)
        {

            // ASCII ART 
            var text = @"
*******************************************************************************
          |                   |                  |                     |
 _________|________________.=""""_;=.______________|_____________________|_______
|                   |  ,-""_,=""""     `""=.|                  |
|___________________|__""=._o`""-._        `""=.______________|___________________
          |                `""=._o`""=._      _`""=._                     |
 _________|_____________________:=._o ""=._.""_.-=""'""=.__________________|_______
|                   |    __.--"" , ; `""=._o."" ,-""""""-._ "".   |
|___________________|_._""  ,. .` ` `` ,  `""-._""-._   "". '__|___________________
          |           |o`""=._` , ""` `; ."". ,  ""-._""-._; ;              |
 _________|___________| ;`-.o`""=._; ."" ` '`.""\` . ""-._ /_______________|_______
|                   | |o;    `""-.o`""=._``  '` "" ,__.--o;   |
|___________________|_| ;     (#) `-.o `""=.`_.--""_o.-; ;___|___________________
____/______/______/___|o;._    ""      `"".o|o_.--""    ;o;____/______/______/____
/______/______/______/_""=._o--._        ; | ;        ; ;/______/______/______/_
____/______/______/______/__""=._o--._   ;o|o;     _._;o;____/______/______/____
/______/______/______/______/____""=._o._; | ;_.--""o.--""_/______/______/______/_
____/______/______/______/______/_____""=.o|o_.--""""___/______/______/______/____
/______/______/______/______/______/______/______/______/______/______/[TomekK]
*******************************************************************************
";

            Console.WriteLine(text);
            Console.WriteLine("Welcome to Treasure Island.");
            Console.WriteLine("Your mission is to find the treasure.");

            Console.WriteLine("You're at a cross road. Where do you want to go? Type \"left\" or \"right\"");
            string c1 = Console.ReadLine();
            if(c1 == "left")
            {
                Console.WriteLine("You\'ve come to a lake. " +
                    "There is an island in the middle of the lake.\n Type \"wait\" to wait for a boat." +
                    " Type \"swim\" to swim across");
                string c2 = Console.ReadLine();
                if(c2 == "wait")
                {
                    Console.WriteLine("You arrive at the island unharmed." +
                        "There is a house with 3 doors.One red, one yellow and one blue." +
                        "\nWhich colour do you choose?");

                    string c3 = Console.ReadLine();
                    if (c3 == "blue")
                    {
                        Console.WriteLine("You enter a room of beasts. Game Over.");
                    } else if (c3 == "red")
                    {
                        Console.WriteLine("It's a room full of fire. Game Over.");
                    }
                    else if (c3 == "yellow")
                    {
                        Console.WriteLine("You found the treasure! You Win!");
                    }
                    else
                    {
                        Console.WriteLine("You chose a door that doesn't exist. Game Over.");
                    }

                }else
                {
                    Console.WriteLine("You get attacked by an angry trout. Game Over.");
                }
            }
            else
            {
                Console.WriteLine("You fell into a hole. Game Over.");
            }

            Console.ReadKey();
        }
    }
}
