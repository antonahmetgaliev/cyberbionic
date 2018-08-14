using System;

namespace L1HWT3Book
{
    class Content
    {
        private string text = null;

        public string Text
        {
            private get
            {
                if (text != "") return text;
                else return "Missing text";
            }
            set { text = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}