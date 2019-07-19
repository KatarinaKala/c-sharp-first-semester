using System;
using NUnit.Framework;

namespace HW_09
{
    [TestFixture]
    public class ExercisesTest
    {
        Exercises exercises;

        [SetUp]
        public void TestSetUp()
        {
            exercises = new Exercises();
        }
        /*
        [Test]
        public void TestJoinTwoStrings() 
        {
            Assert.That(exercises.JoinTwoStrings("tere ", "hommikust"), Is.EquivalentTo("tere hommikust"));
        }

        [Test]
        public void TestArrayLength()//checking that array consist of 6 integers
        {
            Assert.AreEqual(6, exercises.array.Length); 
        }

         [Test]
         public void TestArrayContains100()//checking that array includes number 100
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.Member(100));
        }

        [Test]
        public void TestArrayNr0To20() //checking that array has two numbers in range 0-20
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.Exactly(2).LessThan(21));
        }

        [Test]
        public void TestArrayNr0To60() //checking that array has exactly 4 numbers less than 60
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.Exactly(4).LessThan(61));
        }

        [Test]
        public void TestArrayNr30To200() //checking that array has exactly 4 numbers more than 30
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.Exactly(4).GreaterThan(29));
        }

        [Test]
        public void TestArrayNr100To200() //checking that array has exactly 2 numbers more than 100
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.Exactly(2).GreaterThan(99));
        }

        [Test]
        public void TestArrayNrOver200() //checking that array has numbers until 200
        {
            exercises.ArrayOfSixNr();
            Assert.That(exercises.array, Has.None.GreaterThan(200));
        }

        [Test]
        public void TestBMIUnderweight()
        {
            Assert.That(exercises.CalculateBMI(50, 165), Is.EquivalentTo("Underweight"));
        }

        [Test]
        public void TestBMINormal()
        {
            Assert.That(exercises.CalculateBMI(62, 165.3), Is.EquivalentTo("Normal"));
        }

        [Test]
        public void TestBMIOverweight()
        {
            Assert.That(exercises.CalculateBMI(90, 180), Is.EquivalentTo("Overweight"));
        }

        [Test]
        public void TestBMIObese()
        {
            Assert.That(exercises.CalculateBMI(150, 185.7), Is.EquivalentTo("Obese"));
        }
        */
        [Test]
        public void TestSentence()
        {
            Assert.That(exercises.Sentence("Have a Nice Day"), Is.EquivalentTo("Have*a*Nice*Day"));
        }

        [Test]
        public void TestSentenceSpaces() //test if the output is correct with many spaces
        {
            Assert.That(exercises.Sentence("Nice   Day"), Is.EquivalentTo("Nice*Day"));
        }
    }
}
