using System;

namespace EX_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.a void method with string
            string name = "Kata";
            Console.WriteLine("Hello, {0}", name);

            //1.b void method with two integers
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);

            //1.c method for returning sum of two integers
            int result = AddNumbers(5, 6);
            Console.WriteLine(result);

        }
        //1.c method for returning sum of two integers
        public static int AddNumbers(int a, int b)
        {
            return a + b;
             

        }
    }
}
