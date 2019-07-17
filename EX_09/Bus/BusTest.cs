using System;
using NUnit.Framework;

namespace Bus
{
    [TestFixture]
    public class BusTest
    {
        Bus bus;

        [SetUp]
        public void TestSetUp()
        {
            bus = new Bus();
        }

        [Test] //number of people 60, number of seats 40
        public void Test60People_People()
        {
            bus.PutPeopleInABus(60, 40);
            Assert.That(bus.nrOfPeopleInTheLastBus, Is.EqualTo(20));
        }

        [Test] //number of people 80, number of seats 40
        public void Test60People_Buses()
        {
            bus.PutPeopleInABus(60, 40);
            Assert.That(bus.nrOfBuses, Is.EqualTo(2));
        }

        [Test] //number of people 80, number of seats 40
        public void Test80People_People()
        {
            bus.PutPeopleInABus(80, 40);
            Assert.That(bus.nrOfPeopleInTheLastBus, Is.EqualTo(40));
        }

        [Test] //number of people 60, number of seats 40
        public void Test80People_Buses()
        {
            bus.PutPeopleInABus(80, 40);
            Assert.That(bus.nrOfBuses, Is.EqualTo(2));
        }

        [Test] //number of people 20, number of seats 40
        public void Test20People_People()
        {
            bus.PutPeopleInABus(20, 40);
            Assert.That(bus.nrOfPeopleInTheLastBus, Is.EqualTo(20));
        }

        [Test] //number of people 60, number of seats 40
        public void Test20People_Buses()
        {
            bus.PutPeopleInABus(20, 40);
            Assert.That(bus.nrOfBuses, Is.EqualTo(1));
        }

        [Test] //number of people 40, number of seats 40
        public void Test40People_People()
        {
            bus.PutPeopleInABus(40, 40);
            Assert.That(bus.nrOfPeopleInTheLastBus, Is.EqualTo(40));
        }

        [Test] //number of people 60, number of seats 40
        public void Test40People_Buses()
        {
            bus.PutPeopleInABus(40, 40);
            Assert.That(bus.nrOfBuses, Is.EqualTo(1));
        }
    }
}
