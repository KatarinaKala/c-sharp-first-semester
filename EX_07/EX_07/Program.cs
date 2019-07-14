using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MyBaseClass first = new MyBaseClass(5);
            MyDerivedClass second = new MyDerivedClass();
            MyDerivedClass third = new MyDerivedClass(4);
            MyDerivedClass fourth = new MyDerivedClass("hi");

            MyBaseClass fifth = new MyBaseClass("Hello");
            fifth.PrintName();

            MyDerivedClass changed = new MyDerivedClass("string");
            changed.PrintName();*/

            MyDerivedClass parameterless = new MyDerivedClass();
            parameterless.PrintName();
        }
    }


    public class MyBaseClass
    {
        internal string name;

        public MyBaseClass(int x) : base() // Invoke the parameterless constructor in object
        {
            Console.WriteLine("In the base class constructor taking an int, which is " + x);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is: {0}", name);
        }

        public MyBaseClass(string word) : base() //constructor which takes string as a parameter
        {
            Console.WriteLine("In the base class constructor taking a string, which is " + word);
            name = word;
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass() : this("Mary") // Invoke the MyDerivedClass constructor taking an int
        {
            Console.WriteLine("In the derived class parameterless constructor.");
        }

        public MyDerivedClass(int y) : base(y + 1) // Invoke the MyBaseClass constructor taking an int
        {
            Console.WriteLine("In the derived class constructor taking an int parameter.");
        }

        public MyDerivedClass(string x) : base(x) // Invoke the MyBaseClass constructor taking an int
        {
            Console.WriteLine("In the derived class constructor taking a string parameter.");
        }
    }
}
