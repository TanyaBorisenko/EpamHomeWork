using System;

namespace EpamHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var passengerCar = new PassengerCar(new Engine(453, 12.76, "benz", 345676),
                new Transmission("aut", 5, "USA"),
                new Chassis(4, 453, 13));
            Console.WriteLine(passengerCar);
            var bus = new Bus(new Engine(234, 9.78, "diz", 987342),
                new Transmission("mech", 4, "Russia"),
                new Chassis(4, 876, 10));
            Console.WriteLine(bus);
            var scooter = new Scooter(new Engine(120, 7.3, "benz", 567349),
                new Transmission("mech", 3, "China"),
                new Chassis(2, 167, 7));
            Console.WriteLine(scooter);
            var truck = new Truck(new Engine(342, 12.45, "diz", 678420),
                new Transmission("mech", 4, "Belarus"),
                new Chassis(4, 1349, 23));
            Console.WriteLine(truck);
        }
    }
}