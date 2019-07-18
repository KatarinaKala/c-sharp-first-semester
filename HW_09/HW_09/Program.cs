using System;

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
        }

}
