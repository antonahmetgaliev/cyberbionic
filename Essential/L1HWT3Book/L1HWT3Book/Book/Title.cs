using System;

namespace L1HWT3Book
{
    class Title
    {
        private string content = null;

        public string Content
        {
            private get
            {
                if (content != "") return content;
                else return "Missing title";
            }
            set { content = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}