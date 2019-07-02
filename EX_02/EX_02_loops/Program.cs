using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX_02_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list with three items
            List<string> berries = new List<string>();
            berries.Add("Strawberries");
            berries.Add("Blueberries");
            berries.Add("Rasberries");

            //Foreach loop
            /*foreach (string berry in berries)
            {
                Console.WriteLine(berry);
            }
            // for loop numbers 1-10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //for loop items in list berries
            for (int i = 0; i < berries.Count; i++)
            {
                Console.WriteLine(berries[i]);
            }

            //method to create a list for 100 integers
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine(numbers.Count);

            //while loop numbers 1-10
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }

            //while loop printing items from list berries
            int b = 0;
            while (b < berries.Count)
            {
                Console.WriteLine(berries[b]);
                b++;
            } */

            //asking a string from user until the strings length is 4


            while (true)
            {
                Console.WriteLine("Write one word:");
                string answer = Console.ReadLine();
                if (answer.Length == 4)
                {
                    Console.WriteLine("You enetered a word with length 4, game is over.");
                    break;
                }
            }

        }
    }
}
