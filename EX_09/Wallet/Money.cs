using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    class Money
    {
        private int amount;
        private string currency;

        public Money(int moneyAmount, string moneyCurrency)
        {
            amount = moneyAmount;
            currency = moneyCurrency;
        }

        public bool AreEqual(Money money)
        {
            if (amount == money.amount && currency == money.currency)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Money AddMoney(Money money)
        {
            if (currency == money.currency)
            {
                amount += money.amount;
            }
            return this; //returning the money object

        }

        public Money Multiply(int multiplier)
        {
            amount = amount * multiplier;
            return this;
        }

        public Money Negate()
        {
            amount = -amount;
            return this;
        }

        public Money SubtractMoney(Money money)
        {
            if (currency == money.currency)
            {
                amount -= money.amount;
            }
            return this;
        }

        public string PrintMoney()
        {
            return amount + currency;
        }

        //helper methods
        public int GetAmount()
        {
            return amount;
        }

        public string GetCurrency()
        {
            return currency;
        }


    }

}
