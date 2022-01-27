namespace EpamHomeWork
{
    public class PassengerCar : Machine
    {
        public PassengerCar(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission,
            chassis)
        {
        }

        public PassengerCar()
        {
        }

        public override string ToString()
        {
            return $"Complete information about passenger car:" +
                   $"\nEngine: power {Engine.Power}, type {Engine.Type}, volume {Engine.Volume}, serial number {Engine.SerialNumber}." +
                   $"Transmission: manufacturer {Transmission.Manufacturer}, type {Transmission.Type}, number of gears {Transmission.NumberOfGears}." +
                   $"Chassis: number {Chassis.Number}, permissible load {Chassis.PermissibleLoad}, wheels number {Chassis.WheelsNumber}";
        }
    }
}