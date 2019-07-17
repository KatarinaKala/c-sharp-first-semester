using System;


namespace EX_09
{
    class Program
    {
       
    }

    class Calculator
    {
        public int Subtract(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }
        }

        public double Subtract(double a, double b)
        {
            if (a > b)
            {
                return Math.Round(a - b, 2);
            }
            else
            {
                return Math.Round(b - a, 2);
            }
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return Math.Round(a * b, 2);
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Multiply(double a, double b, double c)
        {
            return Math.Round(a * b * c, 2);
        }

        public int Square(int a)
        {
            return a * a;
        }

        public double Square(double a)
        {
            return a * a;
        }
    }
}
