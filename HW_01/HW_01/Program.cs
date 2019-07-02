using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ül 1
            /* string name = "Kata";
            Console.WriteLine("{0}{1}{2}{3}", name, name, name, name);
            Console.WriteLine("{0}        {1}", name, name);
            Console.WriteLine("{0}        {1}", name, name);
            Console.WriteLine("{0}{1}{2}{3}", name, name, name, name); 

            // Ül 2
            int a = 5;
            int b = 4;

            Console.WriteLine("Your numbers are: {0} and {1}", a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            if (a - b >= 0)
            {
                Console.WriteLine("Square root of {0} is {1}", a - b, Math.Sqrt(a - b));
            }
            else
            {
                Console.WriteLine("Cannot calculate square root, because substraction is negative :(");
            } 

            // Ül 3
            Console.WriteLine("What is the capital of France?");
            string firstAnswer = Console.ReadLine();

            Console.WriteLine("How much is 4*15?");
            string secondAnswer = Console.ReadLine();

            Console.WriteLine("Which country is in the Baltic states? Nter the number of correct answer:");
            Console.WriteLine("1. Poland");
            Console.WriteLine("2. Estonia");
            Console.WriteLine("3. Finland");
            string thirdAnswer = Console.ReadLine();

            int points = 0;
            if (firstAnswer == "Paris" || firstAnswer == "paris")
            {
                points += 1;
            }
            if (secondAnswer == "60")
            {
                points += 1;
            }
            if (thirdAnswer == "2")
            {
                points += 1;
            }

            if (points == 3)
            {
                Console.WriteLine("Your score is: {0}. Great job!", points);
            }
            else
            {
                Console.WriteLine("Unfortunately you got {0} points. Correct answers were:", points);
                Console.WriteLine("1. Paris");
                Console.WriteLine("2. 60");
                Console.WriteLine("3. 2. Estonia");
            } */

            // Ül 4
            Console.WriteLine("How tall are you?");
            int height = int.Parse(Console.ReadLine());

            if (height < 100)
            {
                Console.WriteLine("Oh dear, you are either a child or a midget.");
            }
            else if (100 <= height && height <= 155)
            {
                Console.WriteLine("Not too tall..");
            }
            else if (156 <= height && height <= 195)
            {
                Console.WriteLine("Average height");
            }
            else
            {
                Console.WriteLine("Buying shoes cant be easy for you");
            }
        }
    }
}
