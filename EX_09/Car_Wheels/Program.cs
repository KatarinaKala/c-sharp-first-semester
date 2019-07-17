using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheels_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.PrintWheelInfo(); //no wheels; list is empty
            car.CreateFourWheels(16, "Bridgestone"); //creates 4 wheel objects with size 16 and company bridgestone and adds them to wheels list
            car.PrintWheelInfo(); //calls PrintInfo for every wheel object in wheels list

            Wheel thirdWheel = car.GetTireByIndex(2); //get wheel with index 2 (third item from wheels list)

            Console.WriteLine();
            Console.WriteLine("Changing company to Yokohama");
            thirdWheel.ChangeMaker("Yokohama"); //call ChangeMaker method for third wheel object
            thirdWheel.PrintInfo(); //call info method from third wheel object

            car.PrintWheelInfo(); //print wheel info for all wheels

            Console.WriteLine("Changing second wheels company to Yamaha");
            Wheel secondWheel = car.GetTireByIndex(1);
            secondWheel.ChangeMaker("Yamaha");
            secondWheel.ChangeAge(4);
            secondWheel.PrintInfo();
            car.PrintWheelInfo(); //print wheel info for all wheels

            Console.ReadLine();
        }
    }

    class Car
    {
        List<Wheel> wheels = new List<Wheel>();

        //creates 4 wheel objects and adds them to a list
        public void CreateFourWheels(int size, string makerName)
        {
            for (int i = 0; i < 4; i++)
            {
                wheels.Add(new Wheel(size, makerName));
            }
        }

        //returns wheel object from wheels list
        public Wheel GetTireByIndex(int index)
        {
            //avoid exception and check if index is present in the list
            if (index < wheels.Count)
            {
                return wheels[index]; //return the wheel object
            }
            else
            {
                Console.WriteLine("Car does not have wheel with this index!");
                return null; //return empty object; method always has to return something
            }
        }

        //calls PrintInfo() from all wheel objects in a list
        public void PrintWheelInfo()
        {
            Console.WriteLine();
            Console.WriteLine("This car has {0} wheels", wheels.Count);
            foreach (Wheel wheel in wheels)
            {
                wheel.PrintInfo();
            }
        }
    }

    class Wheel
    {
        private int diameter;
        private string make;
        private int age = 0;

        //constructor, takes diameter and maker company as a parameter
        public Wheel(int diameterToSet, string makerName)
        {
            diameter = diameterToSet;
            make = makerName;
        }

        //method for changing the maker of the wheel
        public void ChangeMaker(string newMake)
        {
            make = newMake;
        }

        public void ChangeAge(int wheelAge)
        {
            age = wheelAge; 
        }

        //method for printing info about a wheel
        public void PrintInfo()
        {
            Console.WriteLine("Wheel size is {0}, age is {1} and company {2}", diameter, age,  make);
        }
    }
}
