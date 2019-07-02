using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3; aritmeetiline operatsioon

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?"); // prindib selle rea ja liigub järgmisele reale
            Console.Write("Type tour first name: "); // prindib selle rea, aga ei lähe järgmisele reale
            string myFirstName; // kasutame uut andmetüüpi- string
            myFirstName = Console.ReadLine(); // salvestab nime, mille kasutaja kirjutab siia muutujasse

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName); // liidad kõik kokku
            Console.ReadLine();
                           
        }
    }
}
