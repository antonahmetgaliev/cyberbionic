namespace L2HWT3Vehicle
{
    internal class Plane:Vehicle
    {
        private readonly int _numberOfPassengers;
        private readonly double _height;

        public Plane(int numberOfPassengers, double height, double price, double maxSpeed, string year) 
            : base(price, maxSpeed, year)
        {
            _numberOfPassengers = numberOfPassengers;
            _height = height;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, {nameof(_numberOfPassengers)}: {_numberOfPassengers}, " +
                   $"{nameof(_height)}: {_height}";
        }
    }
}