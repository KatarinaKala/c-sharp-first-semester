using System;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider regular = new Spider();
            DangerousSpider dangerous = new DangerousSpider();
            DeadlySpider deadly = new DeadlySpider();

            regular.SetName("Imbi");
            regular.SetAge(11);
            regular.PrintInfo();
            regular.Eat("flies");
            regular.Bite();

            Console.WriteLine();

            dangerous.SetName("Ohtlik");
            dangerous.SetAge(5);
            dangerous.PrintInfo();
            dangerous.Eat("mosquitoes");
            dangerous.Bite();

            Console.WriteLine();

            deadly.SetName("Death");
            deadly.SetAge(6);
            deadly.PrintInfo();
            deadly.Eat("everything");
            deadly.Bite();

        }

        interface ISpider //creating interface
        {
            void Bite();
            void Eat(string food);
            void PrintInfo();
            void SetName(string name);
            void SetAge(int age);
        }

        class Spider : ISpider //creating base class Spider
        {
            protected string food;
            protected string name;
            protected int age;
            protected string type;
            protected int maxAge;

            public Spider() //constructor to set type and max age
            {
                type = "regular spider";
                maxAge = 10;
            }

            public virtual void Bite() //method bite
            {
                Console.WriteLine("You have been bitten");
            }

            public void Eat(string foodToEat) //method eat, which takes one parameter
            {
                food = foodToEat;
                Console.WriteLine("Spider is eating " + food);
            }

            public virtual void SetName(string setName) //method to set spiders name
            {
                name = setName;
            }

            public void SetAge(int setAge) //method to set spiders age
            {
                if (setAge <= maxAge)
                {
                    age = setAge;
                }
                else
                {
                    Console.WriteLine("Invalid value for age!");
                }
            }

            public void PrintInfo() //method to print all info about spider
            {
                Console.WriteLine("Spiders name is {0}, it is {1} years old and it's type is {2}", name, age, type);
            }
        }

        class DangerousSpider : Spider //derived class dangerous spider
        {
            public DangerousSpider()
            {
                type = "dangerous spider"; //changed spiders type 
            }

            public override void Bite() //adding sentence for method bite
            {
                base.Bite();
                Console.WriteLine("Seek medical help in 4-8 hours!");
            }
        }

        class DeadlySpider:Spider //second derived class deadly spider
        {
            public DeadlySpider()
            {
                type = "killer"; //changed type
                maxAge = 5; //changed max age
            }

            public override void Bite() //new valu for method bite
            {
                Console.WriteLine("Game over. You have been bitten by a deadly spider!");
            }

            public override void SetName(string setName)
            {
                name = "Deadly" + setName; //new spiders name
            }
        }
    }
}
