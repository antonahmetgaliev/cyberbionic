namespace L2HWT3Vehicle
{
    internal class Vehicle
    {
        private readonly double _price;
        private readonly double _maxSpeed;
        private readonly string _year;

        public Vehicle(double price, double maxSpeed, string year)
        {
            _price = price;
            _maxSpeed = maxSpeed;
            _year = year;
        }

        public virtual string ShowInfo()
        {
            return $"{nameof(_price)}: {_price}, {nameof(_maxSpeed)}: {_maxSpeed}, {nameof(_year)}: {_year}";
        }
    }
}