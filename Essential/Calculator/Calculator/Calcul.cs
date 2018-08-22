namespace Calculator
{
    internal class Calcul
    {
        private readonly double _a;
        private readonly double _b;

        public Calcul(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double Sum()
        {
            return _a + _b;
        }

        public double Sub()
        {
            return _a - _b;
        }

        public double Mul()
        {
            return _a * _b;
        }

        public double Div()
        {
            return _a / _b;
        }
    }
}