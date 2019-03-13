namespace Ferrari
{
    public class Ferrari : IDrivable
    {
        private const string model = "488-Spider";
        private string driver;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        public string Model => model;

        public string DriverName { get; private set; }

        public string Breake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{Breake()}/{Gas()}/{this.DriverName}";
        }

    }
}
