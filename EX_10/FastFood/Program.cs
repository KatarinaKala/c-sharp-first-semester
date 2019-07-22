using System;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            FastFood fastFood = new FastFood();
            /*fastFood.PrintCommands();
            fastFood.PrintItemsAndPrices();
            fastFood.GetCalories("burger");
            fastFood.GetPrice("taco");
            fastFood.AddOrder("fries");
            fastFood.MakeOrder();*/

            //Adding console interface

            bool continueAsking = true;
            bool isOrdering = false;

            fastFood.PrintCommands();
            string input = Console.ReadLine();

            if (continueAsking)
            {
                if (isOrdering)
                {
                    switch (input)
                    {
                        case "E":
                            isOrdering = false;
                            fastFood.MakeOrder();
                            fastFood.PrintCommands();
                            break;
                        default:
                            fastFood.AddOrder(input);
                            Console.WriteLine("Please enter the item you wish to order or E to exit:");
                            break;
                    }
                }
                else
                {
                    switch (input)
                    {
                        case "E":
                            continueAsking = false;
                            break;
                        case "O":
                            isOrdering = true;
                            Console.WriteLine("Please enter the item you wish to order or E to exit:");
                            fastFood.AddOrder(input);
                            break;
                        case "L":
                            fastFood.PrintItemsAndPrices();
                            fastFood.PrintCommands();
                            break;
                        default:
                            Console.WriteLine("Invalid command");
                            fastFood.PrintCommands();
                            break;
                    }
                }
                input = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }

    class FastFood
    {
        Dictionary<string, int> foodAndPrice = new Dictionary<string, int>()
        {
            {"fries", 2},
            {"pizza", 7},
            {"burger", 4},
            {"taco", 5},
            {"coke", 2},
        };

        Dictionary<string, int> foodAndCals = new Dictionary<string, int>()
        {
            {"fries", 500},
            {"pizza", 890},
            {"burger", 700},
            {"taco", 600},
            {"coke", 200},
        };

        private List<string> foodFromOrder = new List<string>();

        public int GetCalories(string foodName)
        {
            if (foodAndCals.ContainsKey(foodName))
            {
                Console.WriteLine(foodAndCals[foodName]);
                return foodAndCals[foodName];
            }
            else
            {
                return 0;
            }
        }

        public int GetPrice(string foodName)
        {
            if (foodAndPrice.ContainsKey(foodName))
            {
                Console.WriteLine(foodAndPrice[foodName]);
                return foodAndPrice[foodName];
            }
            else
            {
                return 0;
            }
        }

        public void PrintItemsAndPrices()
        {
            Console.WriteLine("Printing menu: ");
            foreach (KeyValuePair<string, int> item in foodAndPrice)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public void AddOrder(string foodName)
        {
            if (foodAndPrice.ContainsKey(foodName))
            {
                Console.WriteLine(foodName + " added to order");
                foodFromOrder.Add(foodName);
            }
            else
            {
                Console.WriteLine(foodName + " does not exist in the menu");
            }
        }

        public void MakeOrder()
        {
            string foodOrder = "";
            int totalPrice = 0;
            int totalCals = 0;

            foreach (string food in foodFromOrder)
            {
                foodOrder += food + " ";
                totalPrice += foodAndPrice[food];
                totalCals += foodAndCals[food];
            }

            Console.WriteLine("Items in the order are: {0}. \nTotal price is: {1} and calories {2}", 
                foodOrder, totalPrice, totalCals);
        }

        public void CompleteOrder()
        {
            foodFromOrder.Clear();
        }

        public void PrintCommands()
        {
            Console.WriteLine("- Please enter a command:");
            Console.WriteLine("L- list all food");
            Console.WriteLine("O- order");
            Console.WriteLine("E- exit");
        }
    }
}
