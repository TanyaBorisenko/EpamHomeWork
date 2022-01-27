namespace EpamHomeWork
{
    public class Bus : Machine
    {
        public Bus(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
        }

        public Bus()
        {
        }

        public override string ToString()
        {
            return $"Complete information about bus:" +
                   $"\nEngine: power {Engine.Power}, type {Engine.Type}, volume {Engine.Volume}, serial number {Engine.SerialNumber}." +
                   $"Transmission: manufacturer {Transmission.Manufacturer}, type {Transmission.Type}, number of gears {Transmission.NumberOfGears}." +
                   $"Chassis: number {Chassis.Number}, permissible load {Chassis.PermissibleLoad}, wheels number {Chassis.WheelsNumber}";
        }
    }
}