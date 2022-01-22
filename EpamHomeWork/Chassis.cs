namespace EpamHomeWork
{
    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public int Number { get; set; }
        public double PermissibleLoad { get; set; }

        public Chassis(int wheels, double permissible, int numberChassis)
        {
            WheelsNumber = wheels;
            Number = numberChassis;
            PermissibleLoad = permissible;
        }

        public override string ToString()
        {
            return $"Wheels Number: {WheelsNumber}; Number: {Number}; Permissible Load: {PermissibleLoad};";
        }
    }
}