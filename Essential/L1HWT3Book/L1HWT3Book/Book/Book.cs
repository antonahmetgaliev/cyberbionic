namespace L1HWT3Book
{
    class Book
    {
        private Title _title = null;
        private Author _author = null;
        private Content _content = null;

        void InitBook()
        {
            this._title = new Title();
            this._author = new Author();
            this._content = new Content();
        }

        public Book(string title)
        {
            InitBook();
            this._title.Content = title;
        }
        
        public string Author
        {
            set => this._author.Name = value;
        }

        public string Content
        {
            set => this._content.Text = value;
        }

        public void Show()
        {
            this._title.Show();
            this._author.Show();
            this._content.Show();
        }
    }
}
