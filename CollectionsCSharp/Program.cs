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
            Console.WriteLine("Count and Capacity: {0}, {1}", strList.Count, strList.Capacity);

            // Enumarate the items in the list with a foreach loop in the function
            //PrintList(strList);
            // Access any Item by its index
            Console.WriteLine("Items value: {0}", strList[4]);

            // Remove items from the list 
            strList.RemoveAt(2); // indices
            strList.Remove("Tina Fey");

            // Sort list content
            strList.Sort();
            //PrintList(strList);

            // Search List Content

            Console.WriteLine(strList.Contains("Ron Gallagher")); // Return bool value 

            bool found = strList.Exists(x => x.Length > 15);
            Console.WriteLine("Item found: {0}", found);

            // Advance Search method find and findAll
            string item = "";
            item = strList.Find(x => x.StartsWith("L"));
            Console.WriteLine("Items: {0}", item);
            Console.WriteLine("===============");

            // FindAll for multiple items
            List<string> itemList = strList.FindAll(x => x.StartsWith("L"));
            PrintList(itemList);

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
