using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EpamHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var machines = new List<Machine>
            {
                new Bus(new Engine(234, 9.78, "diz", 987342),
                    new Transmission("mech", 4, "Russia"),
                    new Chassis(4, 876, 10)),
                new PassengerCar(new Engine(453, 12.76, "benz", 345676),
                    new Transmission("aut", 5, "USA"),
                    new Chassis(4, 453, 13)),
                new Scooter(new Engine(120, 0.3, "benz", 567349),
                    new Transmission("mech", 3, "China"),
                    new Chassis(2, 167, 7)),
                new Truck(new Engine(342, 3.45, "diz", 678420),
                    new Transmission("mech", 4, "Belarus"),
                    new Chassis(4, 1349, 23))
            };

            var vehiclesBigCapacity = machines.Where(m => m.Engine.Volume > 1.5d).ToList();

            var busses = machines.Where(m => m.GetType() == typeof(Bus)).ToList();
            var trucks = machines.Where(m => m.GetType() == typeof(Truck)).ToList();

            var toXml = new XElement("BussesAndTrucks",
                from bus in busses
                select new XElement("Bus",
                    new XElement("Type", bus.Engine.Type),
                    new XElement("Power", bus.Engine.Power),
                    new XElement("SerialNumber", bus.Engine.SerialNumber)),
                from truck in trucks
                select new XElement("Truck",
                    new XElement("Type", truck.Engine.Type),
                    new XElement("Power", truck.Engine.Power),
                    new XElement("SerialNumber", truck.Engine.SerialNumber)));

            var groupByTransmission = machines.OrderBy(m => m.Transmission.Type).ToList();

            XmlMachineSerializer.SerializeMachines(vehiclesBigCapacity, "maxCapacity.xml", "Xml");
            XmlMachineSerializer.SerializeMachines(toXml, "busesAndTrucks.xml", "Xml");
            XmlMachineSerializer.SerializeMachines(groupByTransmission, "transmissionType.xml", "Xml");
        }
    }
}