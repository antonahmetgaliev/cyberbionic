namespace L1HWT3Book
{
    class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        void InitBook()
        {
            _title = new Title();
            _author = new Author();
            _content = new Content();
        }

        public Book(string title)
        {
            InitBook();
            _title.Content = title;
        }
        
        public string Author
        {
            set => _author.Name = value;
        }

        public string Content
        {
            set => _content.Text = value;
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}
