using System;
using System.Collections.Generic;
using System.IO;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnterNumber();
            //ReadFile();
            //DivideZero(34, 0);
            IntList();
            //Console.ReadLine();
        }

        public static void EnterNumber() //Exercise 1. parsing
        {
            bool enterString = true;

            while (enterString)
            {
                try
                {
                    /*int a = int.Parse("Tere");
                    Console.WriteLine(a);*/
                    Console.WriteLine("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    enterString = false;
                    Console.WriteLine("Thank you for entering number " + num);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("This is not a number, try again");
                }
            }
        }

        public static void ReadFile() //Exercise 2. Finding file
        {
            try
            {
                Console.WriteLine("Enter files name: ");
                string fileName = Console.ReadLine();
                using (StreamReader reader = new StreamReader(fileName))
                {

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DivideZero(int a, int b) //Exercise 3. Dividing by zero
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero, but your number divided by 2 would be {0}", a / 2);
            }
        }

        public static void IntList() //Trying to get a number from an empty list
        {
            List<int> numbers = new List<int>();

            try
            {
                Console.WriteLine(numbers[1]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
