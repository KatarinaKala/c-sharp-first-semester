using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rows = new List<string>(); //creating list for rows in file
            string line;

            using (StreamReader reader = new StreamReader("Põdramaja.txt"))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    rows.Add(line); //adding rows to the list
                }
            }

            List<string> odd = new List<string>(); //creating list for odd rows
            List<string> even = new List<string>(); //creating list for even rows

            for (int i = 0; i < rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    odd.Add(rows[i]); //adding odd rows to one list
                }
                else
                {
                    even.Add(rows[i]); //adding even rows to another list
                }
            }

            odd.AddRange(even); //adding two lists together

            using (StreamWriter writer = new StreamWriter("different.txt", true))
            {
                foreach (string item in odd)
                {
                    writer.WriteLine(item);
                    Console.WriteLine(item);
                }
            }

        }
    }
}
