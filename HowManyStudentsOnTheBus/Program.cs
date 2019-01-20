using System;

namespace HowManyStudentsOnTheBus
{
    class Program
    {
        static void Main(string[] args)
        {
            //331 students went on a field trip. Six buses were filled and 7 students traveled in cars. 
            //How many students were in each bus?

            int fieldTrip = 331;
            int car = 7;
            int busses = 6;
            int howManyStudentsDidntRideTheBus = fieldTrip - car;
            int howManyStudentsOnEachBus = howManyStudentsDidntRideTheBus / busses;
            Console.WriteLine(howManyStudentsOnEachBus + " students rode each bus.");
           
        }
    }
}
