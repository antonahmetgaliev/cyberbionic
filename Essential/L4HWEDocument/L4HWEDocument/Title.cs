using System;

namespace L4HWEDocument
{
    internal class Title : PartsOfDocument
    {
        private string _content;

        public string Content
        {
            private get { return _content ?? "Заголовок отсутствует."; }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}