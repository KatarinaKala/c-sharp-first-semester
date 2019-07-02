using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine drinkMachine = new VendingMachine();
            drinkMachine.DepositCoin(50);
            drinkMachine.GetDrink();
            drinkMachine.DepositCoin(50);
            drinkMachine.GetDrink();

            Console.WriteLine();
            drinkMachine.DepositCoin(30);
            drinkMachine.GetRefund();
            drinkMachine.GetRefund();
        }

        class VendingMachine
        {
            //Adding field and constant
            private int depositedAmount;
            private int COST_OF_DRINK = 75;

            //Adding constructor without parameters
            public VendingMachine()
            {
                depositedAmount = 0;
            }

            //Adding methods
            public void DepositCoin(int coinAmount)
            {
                depositedAmount += coinAmount;
                Console.WriteLine("depositedAmount value is now: " + depositedAmount);
            }

            public void GetDrink()
            {
                if (depositedAmount >= COST_OF_DRINK)
                {
                    int refund = depositedAmount - COST_OF_DRINK;
                    Console.WriteLine("Your change is {0} cents", refund);
                    depositedAmount = 0;
                }
                else
                {
                    Console.WriteLine("Insert more coins");
                }
            }

            public void GetRefund()
            {
                Console.WriteLine("You were refunded: " + depositedAmount);
                depositedAmount = 0;
            }
        }
    }
}
