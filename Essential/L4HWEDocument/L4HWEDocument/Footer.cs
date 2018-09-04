using System;

namespace L4HWEDocument
{
    internal class Footer : PartsOfDocument
    {
        private string _content;

        public string Content
        {
            private get { return _content ?? "Нижний колонтитул отсутствует."; }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}