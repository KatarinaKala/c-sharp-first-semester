using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Crime = new Book();
            Crime.Interest("crime");
        }

        class Book
        {
            //Adding 3 fields
            private string genre;
            private int pages;
            private bool isInteresting;

            //Adding 4 methods
            public void Interest(string style)
            {
                if (style == "comedy" || style == "crime")
                {
                    isInteresting = true;
                    Console.WriteLine("You chose an interesting book!");
                }
                else
                {
                    isInteresting = false;
                    Console.WriteLine("I don't like that genre so much");
                }
                Console.WriteLine(isInteresting);
            }
        }
    }
}
