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
            this._account = account;
            this._customer = customer;
            this._provider = provider;
            this._quantity = quantity;
            this._article = article;
        }
    }
}
