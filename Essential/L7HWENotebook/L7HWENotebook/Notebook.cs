namespace L7HWENotebook
{
    public struct Notebook
    {
        private readonly string _model;
        private readonly string _manufacturer;
        private readonly int _price;

        public Notebook(string model, string manufacturer, int price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }

        public string Model
        {
            get
            {
                return _model;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
        }
    }
}