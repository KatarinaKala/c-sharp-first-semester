using System;
using System.Collections.Generic;
using System.IO;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string line; //represents the line we read
            List<string> words = new List<string>(); //creating a new list

            using (StreamReader reader = new StreamReader("First.txt"))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    words.Add(line); //adding values from file to list
                }
            }

            words.Reverse(); //Reversing values in list
            int number = 1;

             foreach (string str in words)
             {
                using (StreamWriter writer = new StreamWriter("Reversed.txt", true))
                {
                    writer.WriteLine(number + "." + str); //writing reversed items to new line
                }
                //Console.WriteLine(number + "." + str);
                number += 1;
             }


        }
    }
}
