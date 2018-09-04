namespace L4HWEDocument
{
    internal class Document
    {
        private readonly Title _title;
        private readonly Body _body;
        readonly Footer _footer;

        public Document(Title title, Body body, Footer footer)
        {
            _title = title;
            _body = body;
            _footer = footer;
        }

        public void Show()
        {
            _title.Show();
            _body.Show();
            _footer.Show();
        }
    }
}