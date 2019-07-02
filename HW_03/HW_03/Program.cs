using System;

namespace HW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle first = new Circle();
            first.PrintInfo();
            Console.WriteLine();
            first.SetDiameter(10);
            first.PrintInfo();
            first.PrintCircleArea();
            
        }

        //Creating class Circle
        class Circle
        {
            //Adding 2 fields
            private int radius;
            private int diameter;

            //Method for setting radius
            public void SetRadius(int circleRadius)
            {
                if (circleRadius > 0)
                {
                    radius = circleRadius;
                    diameter = 2 * radius;
                }

                else
                {
                    radius = 0;
                    diameter = 0;
                }

            }

            //Method for setting diameter
            public void SetDiameter(int circleDiameter)
            {
                if (circleDiameter > 0)
                {
                    diameter = circleDiameter;
                    radius = circleDiameter / 2;
                }

                else
                {
                    radius = 0;
                    diameter = 0;
                }
            }

            public void PrintCircleArea()
            {
                double area = Math.Round(Math.PI * (radius * radius), 2);
                Console.WriteLine("Circle area is " + area);
            }

            //Method for printing info about radius and diameter
            public void PrintInfo()
            {
                // if radius and diameter have values
                if (radius > 0 && diameter > 0)
                {
                    Console.WriteLine("Circle radius is {0} and diameter is {1}", radius, diameter);
                }
                else
                {
                    Console.WriteLine("Values are not set!");
                }
            }

            //Adding 2 constructors
           /* public Circle()
            {
                radius = 4;
                diameter = 8;
            }*/
            public Circle()
            {

            }

            public Circle(int circleRadius)
            {
                radius = circleRadius;
                diameter = 2 * radius;
            }
                
        }
    }
}
