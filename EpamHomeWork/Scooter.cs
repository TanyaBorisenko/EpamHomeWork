namespace EpamHomeWork
{
    public class Scooter : Machine
    {
        public Scooter(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
        }

        public Scooter()
        {
        }

        public override string ToString()
        {
            return $"Complete information about scooter:" +
                   $"\nEngine: power {Engine.Power}, type {Engine.Type}, volume {Engine.Volume}, serial number {Engine.SerialNumber}." +
                   $"Transmission: manufacturer {Transmission.Manufacturer}, type {Transmission.Type}, number of gears {Transmission.NumberOfGears}." +
                   $"Chassis: number {Chassis.Number}, permissible load {Chassis.PermissibleLoad}, wheels number {Chassis.WheelsNumber}";
        }
    }
}