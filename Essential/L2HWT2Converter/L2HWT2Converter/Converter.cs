namespace L2HWT2Converter
{
    class Converter
    {
        private readonly double _usd;
        private readonly double _eur;
        private readonly double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double ConvertToCurr(double uah, string curr)
        {
            if (curr == "USD") return uah / _usd;
            if (curr == "EUR") return uah / _eur;
            return uah / _rub;
        }

        public double ConvertToUah(double currDoub, string currStr)
        {
            if (currStr == "USD") return currDoub * _usd;
            if (currStr == "EUR") return currDoub * _eur;
            return currDoub * _rub;
        }
    }
}
