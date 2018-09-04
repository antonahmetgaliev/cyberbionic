using System;

namespace L4HWEDocument
{
    internal class Body : PartsOfDocument
    {
        private string _content;

        public string Content
        {
            private get { return _content ?? "Тело документа отсутствует."; }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}