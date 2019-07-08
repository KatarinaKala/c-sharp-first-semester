using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new instances of the subclasses
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            //Adding instances to array
            IShape[] shapes = new IShape[3];
            shapes[0] = circle;
            shapes[1] = square;
            shapes[2] = triangle;

            foreach (IShape item in shapes)
            {
                item.Draw();
                item.SetColor("red");
                item.SetHeight(4);
                Console.WriteLine();
            }

            circle.CalculatingArea();
            square.CalculatingArea();
            triangle.CalculatingArea(4);
        }

        interface IShape //interface for Shape
        {
            void Draw(); //Method Draw with no parameters
            void SetColor(string color); //Method to set color for the shapes
            void SetHeight(int height);
        }

        public class Shape:IShape //base class
        {
            protected string color;
            protected int height;

            public virtual void Draw() // virtual method Draw
            {
                Console.WriteLine("I am a shape");
            }

            public virtual void SetColor(string colorSet)
            {
                color = colorSet;
                Console.WriteLine("Color was set to " + color);
            }

            public void SetHeight(int heightSet)
            {
                height = heightSet;
                Console.WriteLine("Shapes height is " + height);
            }
        }

        public class Circle:Shape // first subclass
        {
            public override void Draw() //overwriting method Draw
            {
                base.Draw(); //changed method to print out the content form base class
                Console.WriteLine("I am a circle");
            }

            public override void SetColor(string colorSet) //overwriting method SetColor
            {
                base.SetColor("red");
            }

            public void CalculatingArea()
            {
                int radius = height / 2;
                double area = Math.PI * (radius * radius);
                Console.WriteLine("Circles area is " + Math.Round(area, 2));
            }
        }

        public class Square : Shape // second subclass
        {
            public override void Draw() //overwriting method Draw
            {
                base.Draw(); //changed method to print out the content form base class
                Console.WriteLine("I am a square");
            }

            public override void SetColor(string colorSet) //overwriting method SetColor
            {
                base.SetColor("blue");
            }

            public void CalculatingArea()
            {
                int area = height * height;
                Console.WriteLine("Squares area is " + area);
            }
        }

        public class Triangle : Shape // third subclass
        {
            public override void Draw() //overwriting method Draw
            {
                base.Draw(); //changed method to print out the content form base class
                Console.WriteLine("I am a triangle");
            }

            public override void SetColor(string colorSet) //overwriting method SetColor
            {
                base.SetColor("green");
            }

            public void CalculatingArea(int a)
            {
                int area = (a * height) / 2;
                Console.WriteLine("Triangles area is " + area);
            }
        }
    }
}
