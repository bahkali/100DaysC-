using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collection 

            string[] comedians = { "Leo Gallagher", "Rodney Dangerfield", "George Carlin", "Lenny Bruce", "Eddie Murphy", "Louie Anderson" };

            // Create a list
            List<string> strList = new List<string>(10);
            // ADD elements to the list from an existing array
            strList.AddRange(comedians);

            // Add itmes
            strList.Add("Tina Fey");
            strList.Add("Ammy Roehler");

            // Examine the count and capacity
            //Console.WriteLine("Count and Capacity: {0}, {1}", strList.Count, strList.Capacity);

            // Enumarate the items in the list with a foreach loop in the function
            //PrintList(strList);
            // Access any Item by its index
            //Console.WriteLine("Items value: {0}", strList[4]);

            // Remove items from the list 
            strList.RemoveAt(2); // indices
            strList.Remove("Tina Fey");

            // Sort list content
            strList.Sort();
            //PrintList(strList);

            // Search List Content

            //Console.WriteLine(strList.Contains("Ron Gallagher")); // Return bool value 

            bool found = strList.Exists(x => x.Length > 15);
            //Console.WriteLine("Item found: {0}", found);

            // Advance Search method find and findAll
            string item = "";
            item = strList.Find(x => x.StartsWith("L"));
            //Console.WriteLine("Items: {0}", item);
            //Console.WriteLine("===============");

            // FindAll for multiple items
            List<string> itemList = strList.FindAll(x => x.StartsWith("L"));
            //PrintList(itemList);

            //             LinkedList
            //=========================================

            // Define some strings that represent song names
            string[] songs = {"Shout", "Satisfaction", "Help!",
                            "Stairway to Heaven", "Come Sail Away",
                            "All Night Long", "Right Here Right Now"};

            // TODO: Create a LinkedList that holds strings

            LinkedList<string> mylist = new LinkedList<string>(songs);

            // TODO: Items can be added at the front or back of the list
            mylist.AddFirst("Africa");
            mylist.AddLast("The Twist");

            // TODO: Like other collections, a LinkedList can be iterated
            //foreach (string s in mylist) {Console.WriteLine(s);}

            // TODO: First and Last properties return LinkedListNodes
            LinkedListNode<string> first = mylist.First;
            LinkedListNode<string> last = mylist.Last;
            //Console.WriteLine(first.Value);
            //Console.WriteLine(last.Value);

            // TODO: Items can be added or removed relative to an existing item
            mylist.AddAfter(first, "Here comes the sun");
            //foreach(string s in mylist){Console.WriteLine(s);}

            // TODO: Search for items in the list with Contains and Find
            //Console.WriteLine(mylist.Contains("Satisfaction"));
            //Console.WriteLine(mylist.Find("Help"));
            // TODO: The list can then be traversed with those properties
            //Console.WriteLine(first.Next.Value);
            //Console.WriteLine(last.Previous.Value);

            //             Stack
            //=========================================

            // TODO: Create an empty stack
            Stack<string> myStack = new Stack<string>();

            // TODO: The Push function pushes new elements onto the stack
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");
            myStack.Push("five");

            // TODO: The Count property indicates how many elements are on the stack
            //Console.WriteLine("Item Count: {0}", myStack.Count);

            // TODO: Stacks can be enumerated in place without changing the content
            //foreach(string s in myStack){Console.WriteLine(s);}

            // TODO: The Peek function examines the current top element but does not remove it
            string top = myStack.Peek();
            //Console.WriteLine(top);

            // TODO: The Pop function removes an element from the top
            item = myStack.Pop();
            //Console.WriteLine(item);
            //Console.WriteLine("Item count: {0}", myStack.Count);


            // TODO: Search for an element using Contains
            //Console.WriteLine("Item found: {0}", myStack.Contains("five"));

            //             Queue
            //=========================================

            // Create an empty Queue that holds strings
            Queue<string> myQ = new Queue<string>();

            // Add items to the end of the queue
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");

            // use the count property to see how many items there are
            //Console.WriteLine("Item Count: {0}", myQ.Count);

            // Queues can be iterated without changing the structure
            //foreach(string s in myQ) { Console.WriteLine(s); }

            // peek at the front of the queue
            string str = myQ.Peek();
            //Console.WriteLine("The first item is {0}", str);

            // remove items from the front of the queue
            str = myQ.Dequeue();
            //Console.WriteLine("Dequeued item is {0}", str);
            //Console.WriteLine("Dequeued item is {0}", myQ.Dequeue());
            //Console.WriteLine("Item Count: {0}", myQ.Count);
            //foreach (string s in myQ) { Console.WriteLine(s); }

            // see if the queue contains an item
            //Console.WriteLine("Queue contains 'one' : {0}", myQ.Contains("one"));
           // onsole.WriteLine("Queue contains 'four' : {0}", myQ.Contains("four"));

            // Remove all the items
            myQ.Clear();
            //Console.WriteLine("Item count: {0}", myQ.Count);

            //             Dictionaries
            //=========================================

            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileTypes.Add(".bmp", "Bitmap File");
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".html", "HTML Document");
            fileTypes.Add(".jpg", "JPEG Image");

            // use the Count property to see how many items there are
            Console.WriteLine("Count: {0}", fileTypes.Count);
            //foreach (string s in fileTypes){ Console.WriteLine( fileTypes[s]);}

            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");

            // The TryAdd function makes it convenient to see if there's a duplicate
            //bool added = fileTypes.TryAdd(".txt", "Just plain text");
            //Console.WriteLine("Added: {0}", added);

            // Dictionaries are also like associative arrays
            Console.WriteLine("Key value: {0}", fileTypes[".html"]);
            // This way, setting an existing key just overwrites the value
            fileTypes[".html"] = "Web Page";
            Console.WriteLine("key value: {0}", fileTypes[".html"]);

            // See if the Dictionary contains an key or a value
            Console.WriteLine("Contains key: {0}", fileTypes.ContainsKey(".bmp"));
            Console.WriteLine("Contains value: {0}", fileTypes.ContainsValue("HTML Document"));

            // Remove items
            fileTypes.Remove(".bmp");
            Console.WriteLine("Contains key: {0}", fileTypes.ContainsKey(".bmp"));

            Console.ReadKey();
        }

        static void PrintList(List<string> theList)
        {
            foreach(string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
