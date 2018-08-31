namespace L2HWT3Vehicle
{
    internal class Car:Vehicle
    {
        private readonly string _location;

        public Car(string location, double price, double maxSpeed, string year)
            : base(price, maxSpeed, year)
        {
            _location = location;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, {nameof(_location)}: {_location}, ";
        }
    }
}