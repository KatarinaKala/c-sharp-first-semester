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
            //Assert.That(100, Is.SubsetOf(exercises.array));
            Assert.That(exercises.array, Has.Member(100));
        }
    }
}
