namespace EpamHomeWork
{
    public class Engine
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }

        public Engine(int enginePower, double engineVolume, string engineType, int engineSerialNumber)
        {
            Power = enginePower;
            Volume = engineVolume;
            Type = engineType;
            SerialNumber = engineSerialNumber;
        }

        public override string ToString()
        {
            return $"Power: {Power}; Volume: {Volume}, Type {Type}; Serial Number: {SerialNumber};";
        }
    }
}