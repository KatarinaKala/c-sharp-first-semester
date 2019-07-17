using System;
using NUnit.Framework;


namespace EX_09
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;

        [SetUp] //this method is called before each test
        public void TestSetup()
        {
            calculator = new Calculator(); //creating object before testing
        }

        [Test] //testing first method, subtracting two integers.
        public void SubtractTwoInts()
        {
            int expected = calculator.Subtract(7, 8);
            Assert.That(expected, Is.EqualTo(1));
        }

        [Test] //testing second method, subtracting two doubles.
        public void SubtractTwoDoubles()
        {
            double expected = calculator.Subtract(8.723, 5.2);
            double tolerance = 0.01; //value can differ 0.01 from what we test
            Assert.That(expected, Is.EqualTo(3.52).Within(tolerance));
        }

        [Test] //testing third method, mulitplying two integers.
        public void MulitplyTwoInts()
        {
            int expected = calculator.Multiply(7, 8);
            Assert.That(expected, Is.EqualTo(56));
        }

        [Test] //testing fourth method, mulitplying two doubles.
        public void MulitplyTwoDoubles()
        {
            double expected = calculator.Multiply(7.5, 8.5);
            double tolerance = 0.01; //value can differ 0.01 from what we test
            Assert.That(expected, Is.EqualTo(63.75).Within(tolerance));
        }

        [Test] //testing fifth method, mulitplying three integers.
        public void MulitplyThreeInts()
        {
            int expected = calculator.Multiply(2, 3, 4);
            Assert.That(expected, Is.EqualTo(24));
        }

        [Test] //testing sixth method, mulitplying three doubles.
        public void MulitplyThreeDoubles()
        {
            double expected = calculator.Multiply(2.1, 3, 1.3);
            Assert.That(expected, Is.EqualTo(8.19));
        }

        [Test] //testing seventh method, calculating square of integer.
        public void SquareInt()
        {
            int expected = calculator.Square(7);
            Assert.That(expected, Is.EqualTo(49));
        }

        [Test] //testing eighth method, calculating square of double.
        public void SquareDouble()
        {
            double expected = calculator.Square(2.5);
            Assert.That(expected, Is.EqualTo(6.25).Within(0.01));
        }
    }
}
