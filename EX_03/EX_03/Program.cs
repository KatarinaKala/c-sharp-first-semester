using System;

namespace EX_03
{
    class TestingClass
    {
        static void Main(string[] args)
        {
            Person jhon = new Person();
            jhon.Name = "Jhon";
            jhon.SetOccupation("Student");
            jhon.SetAge(1997);
            jhon.PrintAllInfo();

            //First constructor
            Console.WriteLine();
            Person mary = new Person();
            mary.PrintAllInfo();

            //Second constructor
            Console.WriteLine();
            Person joe = new Person("Joe");
            joe.PrintAllInfo();

            //Third constructor
            Console.WriteLine();
            Person katie = new Person("Katie", 18);
            katie.PrintAllInfo();
        }

        class Person
        {
            //Adding private field
            private int age;
            private string occupation;
            //Adding public property
            public string Name;

            private void GetName()
            {
                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Persons name is unknown");
                }
                else
                {
                    Console.WriteLine("Persons name is: " + Name);
                }
            }

            public void SetOccupation(string personOccupation)
            {
                occupation = personOccupation;
            }

            private void GetOccupation()
            {
                if (string.IsNullOrEmpty(occupation))
                {
                    Console.WriteLine("Persons occupation is: unoccupied");
                }
                else
                {
                    Console.WriteLine("Persons occupation is: " + occupation);
                }
            }

            public void SetAge(int personAge)
            {
                if (personAge > 0 && personAge <= 130)
                {
                    age = personAge;
                }
                else if (personAge >= 1900 && personAge <= DateTime.Now.Year)
                {
                    age = DateTime.Now.Year - personAge;
                }
                else
                {
                    Console.WriteLine("Invalid value for age!");
                    age = 0;
                }

            }

            private void GetAge()
            {
                Console.WriteLine("Persons age is: " + age);
            }

            public void PrintAllInfo()
            {
                GetName();
                GetOccupation();
                GetAge();
            }

            //Adding constructors
            public Person()
            {
                Name = "Mary";
                occupation = "Student";
            }

            public Person(string personName)
            {
                Name = personName;
            }

            public Person(string personName, int personAge)
            {
                Name = personName;
                age = personAge;
            }
        }

    }
}
