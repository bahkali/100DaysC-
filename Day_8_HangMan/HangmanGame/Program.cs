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

            string[] stages =
            {
                @"
                +---+
                  |   |
                  O   |
                 /|\  |
                 / \  |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                  O   |
                 /|\  |
                 /    |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                  O   |
                 /|\  |
                      |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                  O   |
                 /|   |
                      |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                  O   |
                  |   |
                      |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                  O   |
                      |
                      |
                      |
                =========
                ",
                @"
                +---+
                  |   |
                      |
                      |
                      |
                      |
                =========
                " };
            string logo = @"
                             _                                             
                            | |                                            
                            | |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
                            | '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
                            | | | | (_| | | | | (_| | | | | | | (_| | | | |
                            |_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                                                __/ |                      
                                               |___/    
                            ";
            string[] word_list = { 
                        "abruptly",
                        "absurd",
                        "abyss",
                        "affix",
                        "askew",
                        "avenue",
                        "awkward",
                        "axiom",
                        "azure",
                        "bagpipes",
                        "bandwagon",
                        "banjo",
                        "bayou",
                        "beekeeper",
                        "bikini",
                        "blitz",
                        "blizzard",
                        "boggle",
                        "bookworm",
                        "boxcar",
                        "boxful",
                        "buckaroo",
                        "buffalo",
                        "buffoon",
                        "buxom",
                        "buzzard",
                        "buzzing",
                        "buzzwords",
                        "caliph",
                        "cobweb",
                        "cockiness",
                        "croquet",
                        "crypt",
                        "curacao",
                        "cycle",
                        "daiquiri",
                        "dirndl",
                        "disavow",
                        "dizzying",
                        "duplex",
                        "dwarves",
                        "embezzle",
                        "equip",
                        "espionage",
                        "euouae",
                        "exodus",
                        "faking",
                        "fishhook",
                        "fixable",
                        "fjord",
                        "flapjack",
                        "flopping",
                        "fluffiness",
                        "flyby",
                        "foxglove",
                        "frazzled",
                        "frizzled",
                        "fuchsia",
                        "funny",
                        "gabby",
                        "galaxy",
                        "galvanize",
                        "gazebo",
                        "giaour",
                        "gizmo",
                        "glowworm",
                        "glyph",
                        "gnarly",
                        "gnostic",
                        "gossip",
                        "grogginess",
                        "haiku",
                        "haphazard",
                        "hyphen",
                        "iatrogenic",
                        "icebox",
                        "injury",
                        "ivory",
                        "ivy",
                        "jackpot",
                        "jaundice",
                        "jawbreaker",
                        "jaywalk",
                        "jazziest",
                        "jazzy",
                        "jelly",
                        "jigsaw",
                        "jinx",
                        "jiujitsu",
                        "jockey",
                        "jogging",
                        "joking",
                        "jovial",
                        "joyful",
                        "juicy",
                        "jukebox",
                        "jumbo",
                        "kayak",
                        "kazoo",
                        "keyhole",
                        "khaki",
                        "kilobyte",
                        "kiosk",
                        "kitsch",
                        "kiwifruit",
                        "klutz",
                        "knapsack",
                        "larynx",
                        "lengths",
                        "lucky",
                        "luxury",
                        "lymph",
                        "marquis",
                        "matrix",
                        "megahertz",
                        "microwave",
                        "mnemonic",
                        "mystify",
                        "naphtha",
                        "nightclub",
                        "nowadays",
                        "numbskull",
                        "nymph",
                        "onyx",
                        "ovary",
                        "oxidize",
                        "oxygen",
                        "pajama",
                        "peekaboo",
                        "phlegm",
                        "pixel",
                        "pizazz",
                        "pneumonia",
                        "polka",
                        "pshaw",
                        "psyche",
                        "puppy",
                        "puzzling",
                        "quartz",
                        "queue",
                        "quips",
                        "quixotic",
                        "quiz",
                        "quizzes",
                        "quorum",
                        "razzmatazz",
                        "rhubarb",
                        "rhythm",
                        "rickshaw",
                        "schnapps",
                        "scratch",
                        "shiv",
                        "snazzy",
                        "sphinx",
                        "spritz",
                        "squawk",
                        "staff",
                        "strength",
                        "strengths",
                        "stretch",
                        "stronghold",
                        "stymied",
                        "subway",
                        "swivel",
                        "syndrome",
                        "thriftless",
                        "thumbscrew",
                        "topaz",
                        "transcript",
                        "transgress",
                        "transplant",
                        "triphthong",
                        "twelfth",
                        "twelfths",
                        "unknown",
                        "unworthy",
                        "unzip",
                        "uptown",
                        "vaporize",
                        "vixen",
                        "vodka",
                        "voodoo",
                        "vortex",
                        "voyeurism",
                        "walkway",
                        "waltz",
                        "wave",
                        "wavy",
                        "waxy",
                        "wellspring",
                        "wheezy",
                        "whiskey",
                        "whizzing",
                        "whomever",
                        "wimpy",
                        "witchcraft",
                        "wizard",
                        "woozy",
                        "wristwatch",
                        "wyvern",
                        "xylophone",
                        "yachtsman",
                        "yippee",
                        "yoked",
                        "youthful",
                        "yummy",
                        "zephyr",
                        "zigzag",
                        "zigzagging",
                        "zilch",
                        "zipper",
                        "zodiac",
                        "zombie" };
            Random rand = new Random();

            //Randomly choose a word from the word_list and assign it to a variable called chosen_word.
            int randomNumber = rand.Next(word_list.Length);
            string chosen_word = word_list[randomNumber];
            Console.WriteLine(logo);
            Console.WriteLine($" The solution is { chosen_word}.");

            char[] display = new char[chosen_word.Length];
            for (int i = 0; i < chosen_word.Length; i++)
            {
                display[i] = '_';
            }
            Console.WriteLine(display);

            int count = 6;
            // Ask the user to guess a letter and make guess lowercase.
            while (display.Contains('_') && count != 0)
            {
                Console.Write(" Guess a letter: ");
                char guess = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();
                if (display.Contains(guess))
                {
                    Console.WriteLine($" You've already guessed {guess}");
                }
                // Display the display
                for (int i = 0; i < chosen_word.Length; i++)
                {
                    if (guess == chosen_word[i])
                    {
                       display[i] = guess;
                    }

                }
                
                if (!display.Contains(guess)) 
                { 
                    count--;
                    Console.WriteLine($" You guessed {guess}, that's not in the word. You lose a life");
                }
         
                //Print the stage ASCII code
                Console.WriteLine(stages[count]);
                //print display
                foreach (char l in display) Console.Write(l);
                
                Console.WriteLine();
            }

            Console.WriteLine();
            if (!display.Contains('_'))
            {
                Console.WriteLine(" You won");
            }
            else
            {
                Console.WriteLine(" Sorry you run out of attempt. try again to win.");
            }

            //End Program
            Console.Read();
        }
    }
}
