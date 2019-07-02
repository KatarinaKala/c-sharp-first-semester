using System;
using System.IO;


namespace Exercise2_same_time
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            using (StreamReader reader = new StreamReader("questions.txt"))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line); //Asking 3 questions
                    string answer = Console.ReadLine(); //answeringto those 3questions
                    using (StreamWriter writer = new StreamWriter("answers.txt", true))
                    {
                        writer.Write(answer + "\n"); //writing answers to a new file
                    }
                }
            }


        }
    }
}
