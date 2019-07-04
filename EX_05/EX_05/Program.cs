using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EX_05
{
    class Program
    {
        static void Main(string[] args)
        {
            SoupTemp(20, 60);
            RegistrationNumber("abä123");
            Temperature("hhh");
            Code();
            Palindrome("madam");
            Numbers("43928");
        }

        //1.Ex. Method about how much the soup cools down
        public static void SoupTemp(int roomTemp, int soupTemp)
        {
            int difference = Math.Abs(roomTemp - soupTemp); //calculating the difference
            double coolDown7 = difference * 0.13 * 7;
            Console.WriteLine("The soup cools down in 7 minutes {0} degrees.", coolDown7);
        }

        //2.Ex. Method which returns the validity of a car registration number
        public static bool RegistrationNumber(string carNumber)
        {
            List<char> invalidCharacters = new List<char>() {'ä', 'ö', 'ü', 'õ'};
            bool validNumber = true;

            if (carNumber.Length != 6)
            {
                Console.WriteLine("Registration number has to be 6 characters long!");
                validNumber = false;
            }
            else
            {
                string firstPart = carNumber.Substring(0, 3);
                string secondPart = carNumber.Substring(3, 3);

                if (firstPart.All(char.IsDigit) && secondPart.All(char.IsLetter) || firstPart.All(char.IsLetter) && secondPart.All(char.IsDigit))
                {
                    Console.WriteLine("Your registration number is correct!");
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("Registration number has to consist of 3 digits and 3 letters");
                    validNumber = false;
                }
            }
            foreach (char character in carNumber)
            {
                if (invalidCharacters.Contains(character))
                {
                    Console.WriteLine("Invalid character!");
                    validNumber = false;
                }
            }
            return validNumber;
        }

        //3.Ex. Method for converitng Fahrenheit and Celsius
        public static void Temperature(string temp)
        {
            char lastChar = temp[temp.Length - 1];
            string numbers = temp.Substring(0, temp.Length - 1);

            if (numbers.All(char.IsDigit))
            {
                int temperature = int.Parse(numbers);

                if (lastChar == 'f' || lastChar == 'F') //converting Fahrenheit to Celsius
                {
                    double celsius = (temperature - 32) / 1.8;
                    Console.WriteLine("{0}F is {1}C", temperature, Math.Round(celsius, 2));
                }
                else if (lastChar == 'c' || lastChar == 'C') //converting Celsius to Fahrenheit
                {
                    double fahrenheit = temperature * 1.8 + 32;
                    Console.WriteLine("{0}C is {1}F", temperature, Math.Round(fahrenheit, 2));
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        }

        //4.Ex. Method to create a code. Reading and writing files.
        public static void Code()
        {
            string line;
            using (StreamReader reader = new StreamReader("codes.txt"))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    int codeLength = 6;
                    int numbersToAdd = codeLength - line.Length;
                    Random rand = new Random(); //random generator

                    for (int i = 0; i < numbersToAdd; i++)
                    {
                        int add;
                        if (line.Contains('x'))
                        {
                            add = 0;
                        }
                        else
                        {
                            add = rand.Next(0, 10);
                        }
                        line += add;
                    }
                    Console.WriteLine(line);
                    using (StreamWriter writer = new StreamWriter("FinalCodes.txt", true))
                    {
                        writer.WriteLine(line);
                    }
                }

            }
        }

        //5.Ex. Method to check if the word is palindrome or not.
        public static bool Palindrome(string word)
        {
            int subtract = 1;
            for (int i = 0; i < word.Length ; i++)
            {
                if (word[i] != word[word.Length - subtract]) //checking if first letter and last are the same
                {
                    Console.WriteLine("It's not a palindrome");
                    subtract += 1;
                    return false;
                }
                subtract += 1;
            }
            Console.WriteLine("It's a palindrome!");
            return true;
        }

        //6.Ex. Method to find out what the number consists of
        public static void Numbers(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(number[i]);
                char newNumber = number[i];
                string zeros = "";

                for (int j = 0; j < number.Length - i - 1; j++)
                {
                    zeros += "0";
                }

                Console.WriteLine(newNumber + zeros);
            }

        }
    }
}

