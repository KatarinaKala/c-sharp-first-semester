using System;
using System.Collections.Generic;

namespace HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Chiuaua chiuaua = new Chiuaua();

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(animal);
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(chiuaua);

            foreach (IAnimal species in animals)
            {
                species.MakeSound();
                species.SetName("Sellu");
                species.PrintInfo();

                species.Jump();
                species.Jump();
                species.Jump();
                species.Jump();
            }
        }

        interface IAnimal //created interface Animal
        {
            //Adding methods
            void MakeSound();
            void Jump();
            void PrintInfo();
            void SetName(string name);
        }

        class Animal:IAnimal //cretaed class Animal
        {
            protected string type;
            protected int jumpCount;
            protected string name;
            protected int maxNameLength;

            public Animal() //creted constructor
            {
                type = "Animal";
                jumpCount = 1;
                maxNameLength = 0;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Animal is making sound");
            }

            public virtual void Jump()
            {
                Console.WriteLine("{0} has jumped {1} times", type, jumpCount);
                jumpCount++;
            }

            public void SetName(string animalName)
            {
                if (maxNameLength == 0 || animalName.Length <= maxNameLength)
                {
                    name = animalName;
                }
                else
                {
                    Console.WriteLine("Name is too long!");
                }
            }

            public void PrintInfo()
            {
                Console.WriteLine("Animals type is: {0} and name is: {1}", type, name);
            }
        }

        class Dog:Animal //creating derived class dog
        {
            public Dog() //created constructor
            {
                type = "Dog";
                maxNameLength = 8;
            }

            public override void MakeSound()
            {
                Console.WriteLine("Dog is barking"); //overwriting method
            }
        }

        class Cat:Animal //cretaing second derived class Cat
        {
            public Cat() //created constructor
            {
                type = "Cat";
                maxNameLength = 4;
            }

            public override void MakeSound()
            {
                Console.WriteLine("Cat is meowing");
            }

            public override void Jump()
            {
                if (jumpCount <= 3)
                {
                    base.Jump();
                }
                else
                {
                    Console.WriteLine("Cat is tired, must sleep now");
                }
            }
        }

        class Chiuaua:Dog
        {
            public Chiuaua() //construvtor
            {
                type = "Chiauaua";
            }

            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("with a really irritating voice");
            }
        }
    }
}
