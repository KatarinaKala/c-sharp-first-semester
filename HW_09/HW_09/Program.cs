using System;
using System.Collections.Generic;

namespace HW_09
{
    class Program
    {
    }

    class Exercises
    {
        public int[] array = new int[6]; //made an array for second exercise

        public string JoinTwoStrings(string a, string b) //first method to add two strings
        {
            return a + b;
        }

        public int[] ArrayOfSixNr()
        {
            Random random = new Random();

            array[0] = 100;
            array[1] = random.Next(0, 21);
            array[2] = random.Next(0, 21);
            array[3] = random.Next(30, 61);
            array[4] = random.Next(30, 61);
            array[5] = random.Next(100, 201);


            foreach (int nr in array)
            {
                Console.WriteLine(nr);
            }

            return array; ;
        }

        public string CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine(bmi);

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        public string Sentence(string sentence)
        {
            string newSentence = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    if (sentence[i-1] == ' ')
                    {
                        newSentence += null;
                    }
                    else
                    {
                        newSentence += '*';
                    }
                }
                else
                {
                    newSentence += sentence[i];
                }
            }

            return newSentence;
        }
    }
}
