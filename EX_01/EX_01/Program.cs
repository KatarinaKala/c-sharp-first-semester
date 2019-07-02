using System;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Task 1-4
            Console.Write("Katarina");
            Console.WriteLine(""); 
            Console.Write("Kala");
            Console.ReadLine(); 

            //2. Task 5
            Console.WriteLine("5" + 6);
            Console.WriteLine(5 + 6);
            Console.WriteLine("5" + "6"); 

            //3. Tasks 1-4
            string firstName = "noFirstName";
            Console.WriteLine(firstName);
            string lastName = "noLastName";
            firstName = "Kata";
            Console.WriteLine(firstName);
            Console.WriteLine("{0} {1}", firstName, lastName);

            //3. Tasks 5-6
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y); 

            //3. Task 7
            string a = "5";
            int b = 5;
            int num = int.Parse(a);
            Console.WriteLine(num + b); 

            //4. Tasks 1-2
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("Tere, {0} {1}", firstName, lastName); 

            //4. Task 3
            Console.WriteLine("How old are you?");
            string ageStr = Console.ReadLine();
            int ageInt = int.Parse(ageStr);
            int nr = 100 - ageInt;
            Console.WriteLine("In {0} years you will be 100 years old.", nr); 

            //5. Task 1
            int value = 10 / 2;
            if (value == 6)
            {
                Console.WriteLine("It's correct");
            }
            else
            {
                Console.WriteLine("It's not correct");
            } 

            //5. Task 2
            int number = 5;
            Console.WriteLine("Guess the number I'm thinking of in range 1-10:");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("You guessed correctly! My number was {0}", number); 
            }
            else
            {
                Console.WriteLine("Wrong! I thought about number {0}", number);
            } 

            //5. Task 3
            Console.WriteLine("Pick a number in range 1-10:");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine("You have to pick a number between 1 and 10!");
            } 

            //5. Task 4
            string question = "What colour are my eyes?";
            string answer1 = "1. Blue";
            string answer2 = "2. Brown";
            string answer3 = "3. Grey";
            int correct = 3;
            string sentence = "Please enter the number of your answer:";

            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(sentence);

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess == correct)
            {
                Console.WriteLine("Your answer is correct! My eyes are grey");
            }
            else
            {
                Console.WriteLine("Your answer is wrong! The correct answer was number 3");
            }

        }
    }
}
