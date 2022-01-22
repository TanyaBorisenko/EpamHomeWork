namespace EpamHomeWork
{
    public abstract class Machine
    {
        protected Engine Engine { get; set; }
        protected Transmission Transmission { get; set; }
        protected Chassis Chassis { get; set; }

        protected Machine(Engine engine, Transmission transmission, Chassis chassis)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
        }
    }
}