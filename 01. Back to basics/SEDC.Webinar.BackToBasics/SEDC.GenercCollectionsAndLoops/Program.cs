using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.GenercCollectionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Loop structures and generic collections
            //Simple use of for loop to count to 10 
            Console.WriteLine("Counting to 10...");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Counter is now " + i);
            }

            Console.WriteLine("==================================");

            //Simple use of while loop to count to 10 
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("Counter is now " + counter);
                counter++;
            }

            //Declaration and initialization of new list of strings
            List<string> names = new List<string>()
            {
                "Dragan",
                "Dejan",
                "Ivo"
            };

            //Use of methods Add(), AddRange(), Remove(), for add or remove an element from a list
            names.Add("Martin");
            names.AddRange(new List<string> { "Bob", "Jill", "John" });

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("=============== Martin removed ===================");
            names.Remove("Martin");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            //Declaration of dictionary and populating with data by using method Add()
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("Martin Panovski", 070222444);
            phoneBook.Add("Dragan Gelevski", 078223446);
            phoneBook.Add("Dejan Jovanov", 071222444);

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
            }

            Console.WriteLine("=============== SEDC Groups ===================");

            Dictionary<string, List<string>> sedcGroups = new Dictionary<string, List<string>>();
            sedcGroups.Add("G1", new List<string>() { "Ilija", "Maja", "Goran" });
            sedcGroups.Add("G2", new List<string>() { "Irina", "Aleksandar", "Natasha" });

            foreach (var item in sedcGroups)
            {
                Console.Write(item.Key + ": ");
                foreach (var name in item.Value)
                {
                    Console.WriteLine(name + ", ");
                }
            }
            #endregion

            #region Using LINQ for manipulation with collections
            Console.WriteLine("=============== LINQ - Manipulation with generic collections ===================");

            //Getting firs and last element from collection
            Console.WriteLine(names.First());
            Console.WriteLine(names.Last());

            //Filtering a collection using Where() method
            string someName = names.Where(name => name == "Dejan").FirstOrDefault();
            Console.WriteLine("Found name in the list: " + someName);

            string anotherName = names.Where(name => name == "Martin").FirstOrDefault();

            if (anotherName != null)
            {
                Console.WriteLine("Searching for Martin suucessfully! " + anotherName);
            }
            else
            {
                Console.WriteLine("There is no such a name in the names collection!");
            }

            //Filtering a dictionary with Where() and then selecting only the value by using Select()
            long selectedPhone = phoneBook
                                .Where(item => item.Key == "Dragan Gelevski")
                                .Select(phone => phone.Value)
                                .FirstOrDefault();

            Console.WriteLine("Dragan's phone is: " + selectedPhone);
            #endregion


            Console.ReadLine();
        }
    }
}
