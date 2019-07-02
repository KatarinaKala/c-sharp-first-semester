using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharacters();
            PrintModifiedString("test");
            int sum = ReturnRandomNumbersSum(5);
            Console.WriteLine("The sum of integers is: {0}", sum);
            SortedList();
            GuessingNumber(3);
        }
        //1. Writing method PrintCharacters(), no return type, no parameters
        public static void PrintCharacters()
        {
            int number = 6;
            while (number >= 0)
            {
                for (int i = number; i >= 0; i--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                number--;
            }

        }
        //2. Writing method, which takes string as a parameter
        public static void PrintModifiedString(string word)
        {
            foreach (char chr in word)
            {
                Console.Write("{0}a", chr);
            }
        }
        //3. Writing a method, which takes int as a parameter
        public static int ReturnRandomNumbersSum(int x)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();

            //Creating list that adds x random integers in range from 1-10
            for (int i = 0; i < x; i++)
            {
                numbers.Add(random.Next(1, 11));
            }

            //Printing out all the items in the list
            foreach (int nr in numbers)
            {
                Console.Write(nr + " ");
            }
            Console.WriteLine();

            //Returning the sum of integers in list
            int sum = 0;
            foreach (int nr in numbers)
            {
                sum += nr;
            }
            return sum;
        }
        //4. Writing a method that prints out sorted list
        public static void SortedList()
        {
            Console.WriteLine("Please enter 3 strings:");
            List<string> ThreeStrings = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                ThreeStrings.Add(input);
            }

            ThreeStrings.Sort();
            Console.WriteLine("The sorted strings are:");
            foreach (string str in ThreeStrings)
            {
                Console.WriteLine(str);
            }
        }
        //5. Writing a method where user has to guess the number I'm thinking of
        public static void GuessingNumber(int x)
        {
            Console.WriteLine("Guess the number I'm thinking of: ");
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == x)
                {
                    Console.WriteLine("Correct, you guessed my number!");
                    break;
                }

                Console.WriteLine("That's not the number I'm thinking of. Guess again:");
            }
        }

    }
}
