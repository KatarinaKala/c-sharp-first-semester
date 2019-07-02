using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_02_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an array of integers with length 4
            int[] array = new int[4];
            array[0] = 7;
            array[1] = 3;
            array[2] = 3;
            array[3] = 2;

            //Replacing items
            array[0] = 3;
            array[1] = 5;
            array[2] = 6;
            array[3] = 7;

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            //Printing out all the odd numbers
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
