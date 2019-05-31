namespace L2HWT4Invoice
{
    internal class Invoice
    {
        private int _account;
        private string _customer;
        private string _provider;
        private string _article;
        private int _quantity;

        public Invoice(int account, string customer, string provider, int quantity, string article)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _quantity = quantity;
            _article = article;
        }
    }
}
