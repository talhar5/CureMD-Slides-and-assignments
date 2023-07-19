using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding elements to a List:
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(222);
            numbers.Add(300);


            // Accessing elements in a List:
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            string firstPerson = names[0]; // Accessing the first element
            string lastPerson = names[names.Count - 1]; // Accessing the last element


            // Iterating over a List:
            List<int> lumbers = new List<int> { 1, 20, 3, 4, 5 };
            lumbers.Remove(20);
            Console.WriteLine(lumbers.Count);
            foreach (int num in lumbers)
            {
                Console.WriteLine(num);
            }


            // Adding elements to a Dictionary:
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["Alice"] = 25;
            ages["Bob"] = 30;
            ages["Charlie"] = 35;


            // Accessing elements in a Dictionary:
            Dictionary<string, string> capitals = new Dictionary<string, string> {
                { "USA", "Washington D.C." },
                { "UK", "London" },
                { "France", "Paris" }
            };

            string capitalOfUK = capitals["UK"]; // Accessing the value by key
            Console.WriteLine(capitalOfUK);


            // Iterating over a Dictionary:
            Dictionary<string, int> scores = new Dictionary<string, int> {
                { "Alice", 95 },
                { "Bob", 80 },
                { "Charlie", 90 }
            };

            foreach (KeyValuePair<string, int> entry in scores)
            {
                string name = entry.Key;
                int score = entry.Value;
                Console.WriteLine(name + ": " + score);
            }


            Console.ReadKey();
        }
    }
}
