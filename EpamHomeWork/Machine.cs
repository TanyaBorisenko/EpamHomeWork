using System.Xml.Serialization;

namespace EpamHomeWork
{
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(PassengerCar))]
    [XmlInclude(typeof(Scooter))]
    public abstract class Machine
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }

        public Machine()
        {
        }

        public Machine(Engine engine, Transmission transmission, Chassis chassis)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
        }
    }
}