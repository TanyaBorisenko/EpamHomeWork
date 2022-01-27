namespace EpamHomeWork
{
    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }

        public Transmission()
        {
        }

        public Transmission(string typeTransmission, int gears, string transmissionManufacturer)
        {
            Type = typeTransmission;
            NumberOfGears = gears;
            Manufacturer = transmissionManufacturer;
        }

        public override string ToString()
        {
            return $"Type: {Type}; Number of gears: {NumberOfGears}; Manufacturer: {Manufacturer};";
        }
    }
}