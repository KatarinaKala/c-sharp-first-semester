using System;
using NUnit.Framework;

namespace CarNumbers
{
    [TestFixture]
    public class CarNumbersTest
    {
        RegistrationNr registrationNr;

        [SetUp]
        public void TestSetUp()
        {
            registrationNr = new RegistrationNr();
        }

        [Test]
        public void Always4Codes() //testing that codes are always generated 4 at once
        {
            registrationNr.CreateCodes("AXT");
            Assert.That(registrationNr.codes.Count, Is.EqualTo(4));
        }

        [Test]
        public void CorrectLetters() //testing that code contains letters given in the method
        {
            registrationNr.CreateCodes("ABC");
            Assert.That(registrationNr.codes, Has.All.Contains("ABC"));
        }

        [Test]
        public void UniqueCodes() //testing that 4 codes are unique
        {
            Assert.That(registrationNr.codes, Is.Unique);
        }
    }
}
