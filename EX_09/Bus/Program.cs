using System;

namespace Bus
{
    class Program
    {

    }

    class Bus
    {
        public double nrOfPeopleInTheLastBus;
        public double nrOfBuses;

        public void PutPeopleInABus(double people, double seats)
        {
            nrOfBuses = Math.Round(people / seats, 0, MidpointRounding.AwayFromZero); // rounding values (0.5 is rounded up)

            if (people > seats) 
            {
                nrOfPeopleInTheLastBus = people - seats;
            }
            else
            {
                nrOfPeopleInTheLastBus = people;
            }
        }

        public double GetNrOfPeople()
        {
            return nrOfPeopleInTheLastBus;
        }

        public double GetNrOFBuses()
        {
            return nrOfBuses;
        }
    }
}
