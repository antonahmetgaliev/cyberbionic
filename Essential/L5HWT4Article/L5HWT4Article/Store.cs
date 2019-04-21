using System.Collections.Generic;

namespace L5HWT4Article
{
    internal class Store
    {
        private readonly List<Article> _shop = new List<Article>();

        public Store()
        {
        }

        public void EnterValues(string programName, string shopName, int cost)
        {
            _shop.Add(new Article(programName, shopName, cost));
        }

        private string Product(int index)
        {
            var productName = _shop[index].ShowProductName();
            var shopName = _shop[index].ShowShopName();
            var cost = _shop[index].ShowCost();
            return productName + " " + shopName + " " + cost + " UAH";
        }

        public string SearchByIndex(int index)
        {
            return _shop.Count < index+1 ? "Error" : Product(index);
        }

        public string SearchByName(string name)
        {
            for (var i = 0; i < _shop.Count; i++)
            {
                if (name != _shop[i].ShowProductName()) continue;
                return Product(i);
            }
            return "Error";
        }

        public List<string> ShowProducts ()
        {
            var products = new List<string>();
            for (var i = 0; i < _shop.Count; i++)
            {
                products.Add(Product(i));
            }

            return products;
        }
    }
}
