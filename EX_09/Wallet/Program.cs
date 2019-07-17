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
    }
}
