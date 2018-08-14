using System;

namespace L1HWT3Book
{
    class Author
    {
        private string name = null;

        public string Name
        {
            private get
            {
                if (name != "") return name;
                else return "Missing name";
            }
            set { name = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
