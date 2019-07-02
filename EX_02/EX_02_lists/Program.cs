using System;
using System.Collections.Generic;

namespace EX_02_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating new list
            List<string> pets = new List<string>();
            pets.Add("cat"); //adding items to the list
            pets.Add("dog");
            pets.Add("parrot");

            //printig element with index 2
            Console.WriteLine(pets[2]);
            //printing lists length
            Console.WriteLine(pets.Count);

            //removing item on index 2 
            pets.RemoveAt(2);
            //printing lists length
            Console.WriteLine(pets.Count);

            //removing item by its value
            pets.Remove("cat");

            //creating second list
            List<string> wildAnimals = new List<string>();
            wildAnimals.Add("tiger");
            wildAnimals.Add("rhino");

            //adding two lists together
            pets.AddRange(wildAnimals);
            Console.WriteLine(pets.Count);
            Console.WriteLine(pets[2]);
        }
    }
}
