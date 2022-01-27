namespace EpamHomeWork
{
    public class Truck : Machine
    {
        public Truck(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
        }

        public Truck()
        {
        }

        public override string ToString()
        {
            return $"Complete information about truck:" +
                   $"\nEngine: power {Engine.Power}, type {Engine.Type}, volume {Engine.Volume}, serial number {Engine.SerialNumber}." +
                   $"Transmission: manufacturer {Transmission.Manufacturer}, type {Transmission.Type}, number of gears {Transmission.NumberOfGears}." +
                   $"Chassis: number {Chassis.Number}, permissible load {Chassis.PermissibleLoad}, wheels number {Chassis.WheelsNumber}";
        }
    }
}