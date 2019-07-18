using System;
using System.Collections.Generic;

namespace Wallet
{
    class Wallet
    {
        List<Money> moneyInWallet = new List<Money>(); //Creating list to add all the money in here

        public Wallet(Money money) //constructor which takes money as parameter and adds it to wallet
        {
            moneyInWallet.Add(money);
        }

        public Money FindMoney(string currency)
        {
            foreach (Money money in moneyInWallet) //checking all the objects in Money class
            {
                if (currency == money.GetCurrency()) //checking if we have the right currency in wallet
                {
                    return money; //if we have, we return object
                }
            }
            return null;  
        }

        public void AddMoneyToWallet(Money moneyToAdd)
        {
            Money existingmoney = FindMoney(moneyToAdd.GetCurrency()); //finding existing money by currency

            if (existingmoney == null) //if we don't have that currency, then we add it
            {
                moneyInWallet.Add(moneyToAdd);
            }
            else
            {
                existingmoney.AddMoney(moneyToAdd); //if we already have that currency, we increase the value
            }
        }

        public bool EqualWallets(Wallet walletToCompare)
        {
            if (moneyInWallet.Count != walletToCompare.moneyInWallet.Count) //checking if we have the same amount of money objects
            {
                return false;
            }
            foreach (Money money in moneyInWallet)
            {
                if (walletToCompare.FindMoney(money.GetCurrency()) == null) //checking if we have the same currencies
                {
                    return false;
                }
            }
            return true;
        }

        public Wallet AddWallets(Wallet walletToAdd)
        {
            foreach (Money money in walletToAdd.moneyInWallet)
            {
                AddMoneyToWallet(money);
            }
            return this;
        }

        public Wallet MultiplyWallet(int multiplier)
        {
            foreach (Money money in moneyInWallet)
            {
                money.Multiply(multiplier);
            }
            return this;
        }

        public Wallet NegateWallet()
        {
            foreach (Money money in moneyInWallet)
            {
                money.Negate();
            }
            return this;
        }

        public Wallet SubtractWallet(Money money)
        {
            foreach (Money m in moneyInWallet)
            {
                m.SubtractMoney(money);
            }
            return this;
        }

        public Wallet SubtractWallets(Wallet walletToSubtract)
        {
            foreach (Money money in walletToSubtract.moneyInWallet)
            {
                walletToSubtract.SubtractWallet(money);
            }
            return this;
        }
    }
}
