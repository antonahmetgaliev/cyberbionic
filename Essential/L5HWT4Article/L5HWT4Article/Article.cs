namespace L5HWT4Article
{
    internal class Article
    {
        private string _productName;
        private string _shopName;
        private double _cost;

        public Article(string productName, string shopName, double cost)
        {
            _productName = productName;
            _shopName = shopName;
            _cost = cost;
        }
    }
}