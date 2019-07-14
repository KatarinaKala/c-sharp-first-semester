using System;
using System.Collections.Generic;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Silver silver = new Silver();
            Bronze bronze = new Bronze();
            Gold gold = new Gold();

            List<ITicket> tickets = new List<ITicket>();
            tickets.Add(silver);
            tickets.Add(bronze);
            tickets.Add(gold);

            Random rnd = new Random();

            foreach (ITicket ticket in tickets)
            {
                Console.WriteLine("Selling tickets:");
                for (int i = 0; i < 30; i++)
                {
                    ticket.SellingTicket(rnd.Next(0, 100));
                }
            }
            Console.ReadLine();
        }
    }

    interface ITicket
    {
        void SellingTicket(int distance); //all classes must have this method
    }

    class Silver:ITicket
    {
        protected string type;
        protected string zone;
        protected double price;
        protected List<int> ticketPrice;

        public Silver()
        {
            type = "Silver ticket";
            ticketPrice = new List<int>() { 3, 4, 5};
        }

        public virtual void SellingTicket(int distance)
        {
            if (distance > 0 && distance <= 80)
            {
                GetZonePrice(distance);
                PrintInfo();
            }
            else
            {
                Console.WriteLine("Invald distance!");
            }
        }

        public void GetZonePrice(int distance)
        {
            if (distance > 0 && distance <= 30)
            {
                zone = "A";
                price = ticketPrice[0];
            }
            else if (distance > 30 && distance <= 60)
            {
                zone = "B";
                price = ticketPrice[1];
            }
            else if (distance > 60 && distance <= 80)
            {
                zone = "C";
                price = ticketPrice[2];
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("You bought a {0} for zone {1} with price {2} €", type, zone, price);
        }
    }

    class Bronze:Silver
    {
        protected int ticketCount;
        protected int freeTicket;
        protected double percentage;

        public Bronze()
        {
            type = "Bronze ticket";
            ticketPrice = new List<int>() { 3, 4, 5 };
            ticketCount = 1;
            freeTicket = 5;
            percentage = 0.1;
        }

        public override void SellingTicket(int distance)
        {
            if (distance > 0 && distance <= 80)
            {
                GetZonePrice(distance);
                CalculateDiscount();
                ticketCount++;
                PrintInfo();
            }
            else
            {
                Console.WriteLine("Invald distance!");
            }
        }

        public void CalculateDiscount()
        {
            if (ticketCount == freeTicket)
            {
                price = price - (price * percentage);
                ticketCount = 0;
            }
        }
    }

    class Gold:Bronze
    {
        public Gold()
        {
            type = "Golden ticket";
            ticketPrice = new List<int>() { 5, 7, 9 };
            ticketCount = 1;
            freeTicket = 4;
            percentage = 0.2;
        }
    }
}
