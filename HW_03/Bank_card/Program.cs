using System;

namespace Bank_card
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCard card1 = new BankCard();
            card1.SetCardNumber("123");
            card1.SetCardNumber("12345678");
            card1.AddMoney(50);
            card1.AddMoney(0.5);
            card1.PrintAccountBalance();
            card1.SubtractMoney(50);
            card1.PrintAccountBalance();
            card1.SubtractMoney(50);

            Console.WriteLine();

            BankCard card2 = new BankCard(100, "Visa");
            card2.SetCardNumber("xys");
            card2.SetCardNumber("87654321");
            card2.AddMoney(100);
            card2.PrintAccountBalance();
            card2.SubtractMoney(200);
            card2.PrintAccountBalance();
            card2.SubtractMoney(10);

        }

        class BankCard
        {
            //Creating 3 fields
            private double accountBalance;
            private string cardType;
            private string cardNumber;

            //Method for setting the card number
            public void SetCardNumber(string number)
            {
                if(number.Length == 8)
                {
                    cardNumber = number;
                    Console.WriteLine("Your card number is " + number);
                }
                else
                {
                    Console.WriteLine("Invalid value, the correct format is 8 digits.");
                }
            }

            //Method for printing card type
            public void PrintCardType()
            {
                Console.WriteLine("Your card type is " + cardType);
            }

            //Method for printing account balance
            public void PrintAccountBalance()
            {
                Console.WriteLine("Your account balance is " + accountBalance);
            }

            //Method for returning account balance
            public double GetAccountBalance()
            {
                return accountBalance;
            }

            //Method for adding money to account
            public void AddMoney(double money)
            {
                accountBalance += money;
                Console.WriteLine("Account balance is now: " + accountBalance);
            }

            //Method for subtracting money from account
            public void SubtractMoney(double money)
            {
                if (accountBalance - money < 0)
                {
                    Console.WriteLine("Cannot do this operation, insufficient funds");
                }
                else
                {
                    accountBalance -= money;
                }
            }

            //Creating 2 constructors
            public BankCard()
            {
                accountBalance = 0;
                cardType = "Visa";
            }
            public BankCard(double balance, string bankCardType)
            {
                accountBalance = balance;
                cardType = bankCardType;
            }
        }
    }
}
