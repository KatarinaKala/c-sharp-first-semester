using System;
using NUnit.Framework;

namespace Wallet
{
    [TestFixture]
    public class MoneyTest
    {
        private Money _12EUR;
        private Money _14EUR;
        private Money _7USD;
        private Money _21USD;

        private Wallet Wallet1;
        private Wallet Wallet2;

        [SetUp]
        protected void SetUp()
        {
            _12EUR = new Money(12, "EUR");
            _14EUR = new Money(14, "EUR");
            _7USD = new Money(7, "USD");
            _21USD = new Money(21, "USD");

            Wallet1 = new Wallet(_12EUR);
            Wallet2 = new Wallet(_14EUR);
        }

        [Test]
        public void TestMoneyEquality()
        {
            Assert.IsTrue(_12EUR.AreEqual(new Money(12, "EUR"))); //Checking if two money objects are equal
        }
        [Test]
        public void TestMoneyNotEqual()
        {
            Assert.IsFalse(_7USD.AreEqual(new Money(12, "EUR"))); //Checking if two money objects are not equal
        }

        [Test]
        public void SimpleAdd() //Test adding money
        {
            // [12 EUR] + [14 EUR] == [26 EUR]
            _12EUR.AddMoney(_14EUR);
            Money expected = new Money(26, "EUR");
            Assert.IsTrue(expected.AreEqual(_12EUR));
        }

        [Test]
        public void MoneyMultiply()
        {
            // [14 EUR] *2 == [28 EUR]
            _14EUR.Multiply(2);
            Money expected = new Money(28, "EUR");
            Assert.IsTrue(expected.AreEqual(_14EUR));
        }

        [Test]
        public void MoneyNegate()
        {
            // [14 EUR] negate == [-14 EUR]
            _14EUR.Negate();
            Money expected = new Money(-14, "EUR");
            Assert.IsTrue(expected.AreEqual(_14EUR));
        }

        [Test]
        public void MoneySubtract()
        {
            // [14 EUR] -[4 EUR] == [-10 EUR]
            _14EUR.SubtractMoney(new Money(4, "EUR"));
            Money expected = new Money(10, "EUR");
            Assert.IsTrue(expected.AreEqual(_14EUR));
        }

        [Test]
        public void PrintMoney()
        {
            // [12 EUR] -> "12EUR"
            string expected = "12EUR";
            _12EUR.PrintMoney();
            Assert.AreEqual(expected, _12EUR.PrintMoney());
        }

        [Test]
        public void WalletContainsValue()
        {
            //Create a wallet containing _12EUR
            //Find euros from wallet and see if the value is 12EUR
            Money moneyFromWallet = Wallet1.FindMoney("EUR");
            Assert.AreEqual(moneyFromWallet, _12EUR);
        }

        [Test]
        public void MoneyWasAddedToWallet()
        {
            // {[12 EUR]} + [14 EUR] == [26 EUR]
            Wallet1.AddMoneyToWallet(_14EUR);
            Money expected = new Money(26, "EUR");
            Money findCurrency = Wallet1.FindMoney("EUR");
            Assert.IsTrue(expected.AreEqual(findCurrency));
        }
        /*
        [Test]
        public void AreTwoWalletsEqual()
        {
            // {[12 EUR], [14EUR]}  ==  { [14EUR], [12EUR]}  

        }

        [Test]
        public void WalletSimpleAdd() //Add money to Wallet
        {
            // {[12 EUR][7 USD]} + [14 EUR] == {[26 EUR][7 USD]}

        }


        [Test]
        public void WalletMultiply()
        {
            // {[12 EUR][7 USD]} *2 == {[24 EUR][14 USD]}

        }

        [Test]
        public void WalletNegate()
        {
            // {[12 EUR][7 USD]} negate == {[-12 EUR][-7 USD]}
        }

        [Test]
        public void WalletSumAdd()  //add 2 Wallets
        {
            // {[12 EUR][7 USD]} + {[14 EUR][21 USD]} == {[26 EUR][28 USD]}

        }

        [Test]
        public void SubtractMoneyFromWallet()
        {
            // [14 EUR][26USD]  - [10EUR] == [4 EUR][26USD]
        }

        [Test]
        public void SubtractWalletFromWallet()
        {
            // [14 EUR][26USD]  - [10EUR][6USD] == [4 EUR][20USD]
        }*/
    }

}
