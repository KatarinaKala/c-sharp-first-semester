using System;

namespace HW_07
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBall normal = new NormalBall("Nikes");
            YouthBall youth = new YouthBall("Adidas");
            Random random = new Random();

            /*for (int i = 0; i < 20; i++) //Checking 20 times if the ball was inside the goal
            {
                normal.IsGoal(random.Next(-50, 50)); //Creating random coordinates
            }
            normal.GoalsCount(); //Printing how many goals were in

            for (int i = 0; i < 10; i++) //Calculating average speed for 10 random coordinates
            {
                int startPos = random.Next(-45, 46);
                int finalPos = random.Next(-45, 46);
                int time = random.Next(0,20);
                Console.WriteLine(normal.BallSpeed(startPos, finalPos, time));
            }*/

            for (int i = 0; i < 5; i++) //Finding kinetic energy with velocity from 1 to 5
            {
                normal.KineticEnergy(random.Next(1, 6));
            }

            normal.BallCode(); //creating code for ball

        }
    }

    interface IBall
    {
        double BallSpeed(double startPos, double finalPos, double time);
        void IsGoal(double ballCoord);
        void KineticEnergy(int velocity);
        void GoalsCount();
        void BallCode();
    }

    class NormalBall:IBall
    {
        protected double diameter;
        protected double goalDepth;
        protected double weight;
        protected double speed = 0;
        protected int isGoal = 0;
        protected int notGoal = 0;
        protected string sponsorName;
        protected int maxLetters;
        protected int maxNumbers;

        public NormalBall(string sponsor) : base()
        {
            sponsorName = sponsor;
            diameter = 0.7;
            goalDepth = 1.7;
            weight = 0.45;
            maxLetters = 4;
            maxNumbers = 5;
        }

        public bool Coordinates(double startPos, double finalPos)
        {
            double absStart = Math.Abs(startPos);
            double absFinal = Math.Abs(finalPos);

            if (absStart <= 45 && absStart >=0 && absFinal <= 45 && absFinal >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid coordinates!");
                return false;
            }
        }

        public double BallSpeed(double startPos, double finalPos, double time)
        {
            if (Coordinates(startPos, finalPos))
            {
                speed = Math.Round(Math.Abs((startPos - finalPos)) / time, 2);
                //Console.WriteLine("Balls speed is: " + speed);
            }
            else
            {
                Console.WriteLine("Can not calculate ball speed!");
            }
            return speed;
        }

        public void IsGoal(double ballCoord)
        {
            if (Math.Abs(ballCoord) <= 45 && Math.Abs(ballCoord) - (diameter / 2) >= 45 - goalDepth)
            {
                Console.WriteLine("It's a goal!");
                isGoal++;
            }
            else
            {
                Console.WriteLine("Unfortunately it isn't a goal..");
                notGoal++;
            }
        }

        public void KineticEnergy(int velocity)
        {
            double energy = weight * (velocity * velocity) / 2;
            Console.WriteLine("Balls kinetic energy is: " + energy);
        }

        public void GoalsCount()
        {
            Console.WriteLine("You got {0} goals that counted and {1} goals that didn't count.", isGoal, notGoal);
        }

        public void BallCode()
        {
            string code = "";
            Random random = new Random();

            if (sponsorName.Length <= maxLetters)
            {
                code += sponsorName;
            }
            else
            {
                for (int i = 0; i < maxLetters; i++)
                {
                    code += sponsorName[i];
                }
            }

            for (int i = 0; i < maxNumbers; i++)
            {
                code += random.Next(0, 10);
            }
            Console.WriteLine("Balls code is: " + code);
        }
    }

    class YouthBall:NormalBall
    {
        public YouthBall(string name) : base(name)
        {
            sponsorName = name;
            diameter = 0.56;
            goalDepth = 1.4;
            weight = 0.38;
            maxLetters = 3;
            maxNumbers = 3;
        }
    }
}
