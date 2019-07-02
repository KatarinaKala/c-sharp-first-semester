using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string line; //represents the line that we read
            using (StreamReader reader = new StreamReader("fruits.txt"))
            {
                /*line = reader.ReadLine(); 
                Console.WriteLine(line); //prints the first line from file*/

                List<string> fruit = new List<string>(); //creating a new list 

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    fruit.Add(line); //adding values from file to list
                    Console.WriteLine(line);
                }
                Console.WriteLine();

               /* foreach (string str in fruit)
                {
                    Console.WriteLine(str); //printing out all the values from list
                }*/

                fruit.Sort(); //sorting list

                foreach (string str in fruit) //printing out sorted list
                {
                    Console.WriteLine(str);
                }

               using (StreamWriter writer = new StreamWriter("sortedList.txt", false))
                {
                    foreach (string str in fruit)
                    {
                        writer.Write(str + "\n"); //writer.Write() writes text to file
                    }


                }
            }
        }
    }
}
