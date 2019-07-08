using System;

namespace BankCard
{
    class Program
    {
        static void Main(string[] args)
        {
            DebitCard debit = new DebitCard();
            //debit.AccountBalance();
            /*debit.AddMoney(500);
            debit.MakePayment(50);
            debit.PrintInfo();
            debit.CloseCard();
            debit.PrintInfo();
            debit.ReOpenCard();
            debit.PrintInfo();*/

            CreditCard credit = new CreditCard();
            credit.AccountBalance();
            credit.AddMoney(500);
            credit.ReOpenCard();
            credit.AddMoney(500);
            credit.MakePayment(800);
            credit.PrintInfo();
        }

        interface ICard
        {
            void AccountBalance();
            void AddMoney(int money);
            void MakePayment(int amount);
            void PrintInfo();
            void CloseCard();
            void ReOpenCard();
        }

        class DebitCard : ICard //base class debit card
        {
            protected int accountBalance = 0;
            protected string cardType;
            protected bool isOpen;
            protected int numberLength;
            protected string cardNumber;

            public DebitCard() //constructor
            {
                cardType = "debit";
                isOpen = true;
                numberLength = 8;
                CardNumber();
            }

            private void CardNumber() //private method to generate card number
            {
                Random rand = new Random(); //random generator

                for (int i = 0; i <= numberLength - 1; i++)
                {
                    cardNumber += rand.Next(0, 10);
                }
            }

            public void AccountBalance() //method to get account balance
            {
                Console.WriteLine("You have {0} euros on your bank account", accountBalance);
            }

            public void AddMoney(int moneyToAdd) //method to add money to your account
            {
                if (isOpen)
                {
                    accountBalance += moneyToAdd;
                    AccountBalance(); //To print out new balance
                }
                else
                {
                    Console.WriteLine("Your card is closed, can't add money to your account.");
                }
            }

            public virtual void MakePayment(int amount) //method to make payment
            {
                if (isOpen)
                {
                    if (accountBalance - amount >= 0)
                    {
                        accountBalance -= amount;
                        AccountBalance(); //To print out new balance
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money on your card!");
                    }
                }
                else
                {
                    Console.WriteLine("Your card is closed, cannot make the payment.");
                }
            }

            public virtual void PrintInfo() //method to print cards info
            {
                Console.WriteLine("Card type: {0}; Card is open: {1}; Card number: {2}", cardType, isOpen, cardNumber);
            }

            public void CloseCard() //method to close the card
            {
                isOpen = false;
                Console.WriteLine("Your card is closed now");
            }

            public void ReOpenCard() //method to re-open the card
            {
                isOpen = true;
                Console.WriteLine("Your card is open again!");
            }
        }

        class CreditCard:DebitCard
        {
            protected int creditLimit;

            public CreditCard() //constructor
            {
                cardType = "credit";
                isOpen = false;
                creditLimit = 300;
                numberLength = 6;
                CardNumber();
            }

            private void CardNumber() //private method to generate card number
            {
                Random rand = new Random(); //random generator

                for (int i = 0; i <= numberLength - 1; i++)
                {
                    cardNumber += rand.Next(0, 10);
                }
            }

            public override void MakePayment(int amount)
            {
                if (isOpen)
                {
                    if (accountBalance + creditLimit >= amount)
                    {
                        accountBalance -= amount;
                        AccountBalance(); //To print out new balance
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money on your card!");
                    }
                }
                else
                {
                    Console.WriteLine("Your card is closed, cannot make the payment.");
                }
            }

            public override void PrintInfo()
            {
                base.PrintInfo();
                Console.Write(" ; credit limit: " + creditLimit);
            }
        }
    }
}
