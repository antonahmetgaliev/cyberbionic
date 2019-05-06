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
    }
}