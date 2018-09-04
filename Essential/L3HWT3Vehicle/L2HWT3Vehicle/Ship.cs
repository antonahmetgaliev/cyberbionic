namespace L2HWT3Vehicle
{
    internal class Ship:Vehicle
    {
        private readonly int _numberOfPassengers;
        private readonly string _portOfResidence;

        public Ship(int numberOfPassengers, string portOfResidence, double price, double maxSpeed, string year)
            : base(price, maxSpeed, year)
        {
            _numberOfPassengers = numberOfPassengers;
            _portOfResidence = portOfResidence;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, {nameof(_numberOfPassengers)}: {_numberOfPassengers}, " +
                   $"{nameof(_portOfResidence)}: {_portOfResidence}";
        }
    }
}