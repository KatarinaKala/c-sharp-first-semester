using System;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square(4);
           // Square(3);
            /*Square(1);
            Square(0);*/
        }

        private static void Square(int number) //creating a square method
        {
            int count = number;

            while (count > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    //Console.Write(number);
                    using (StreamWriter writer = new StreamWriter("Square.txt", true))
                    {
                        writer.Write(number);
                    }
                }

                using (StreamWriter writer = new StreamWriter("Square.txt", true))
                {
                    writer.WriteLine();
                }

                //Console.WriteLine();
                count -= 1;
            }

        }
    }
}
