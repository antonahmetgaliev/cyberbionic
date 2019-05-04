namespace L5HWT4Article
{
    internal class Article
    {
        private readonly string _productName;
        private readonly string _shopName;
        private readonly int _cost;

        public Article(string productName, string shopName, int cost)
        {
            _productName = productName;
            _shopName = shopName;
            _cost = cost;
        }

        public string ShowProductName => _productName;

        public string ShowShopName => _shopName;

        public int ShowCost => _cost;
    }
}