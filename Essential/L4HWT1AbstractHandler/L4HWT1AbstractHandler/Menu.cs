using System;

namespace L4HWT1AbstractHandler
{
    internal class Menu
    {
        private string _resultStr;
        private int _resultInt;

        public bool Try()
        {
            if (_resultInt != 0)
                if (_resultStr != "")
                {
                    Console.Write("\nDo u want return to menu? (Y/N)");
                    var exit = Console.ReadKey();
                    Console.Clear();
                    return exit.Key != ConsoleKey.N;
                }

            return false;
        }
        private static string Color(string str)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("> {0}", str);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            return str;
        }
        private void Show(string str)
        {
            Console.WriteLine("- {0}", str);
        }
        public string CreateMenuStr(string [] body)
        {
            ConsoleKeyInfo choise;
            var i = 1;
            var quan = body.Length-1;
            _resultStr = "";
            do
            {
                Console.Clear();
                if (body[0]!="") Console.WriteLine(body[0]);
                for (int j = 1; j < body.Length; j++)
                {
                    if (j==i) _resultStr = Color(body[j]);
                    else Show(body[j]);
                }
                Console.WriteLine("\nPress Esc for exit");
                choise = Console.ReadKey();
                if (choise.Key == ConsoleKey.DownArrow)
                {
                    if (i == quan)
                        i = 1;
                    else ++i;
                }
                if (choise.Key == ConsoleKey.UpArrow)
                {
                    if (i == 1)
                        i = quan;
                    else --i;
                }
                if (choise.Key == ConsoleKey.Escape)
                    return "exit";
            } while (choise.Key != ConsoleKey.Enter);
            return _resultStr;
        }
        public int CreateMenuInt(string[] body)
        {
            ConsoleKeyInfo choise;
            var i = 1;
            var quan = body.Length - 1;
            do
            {
                Console.Clear();
                if (body[0] != "") Console.WriteLine(body[0]);
                for (int j = 1; j < body.Length; j++)
                {
                    if (j == i) Color(body[j]);
                    else Show(body[j]);
                }
                Console.WriteLine("\nPress Esc for exit");
                choise = Console.ReadKey();
                if (choise.Key == ConsoleKey.DownArrow)
                {
                    if (i == quan)
                        i = 1;
                    else ++i;
                }
                if (choise.Key == ConsoleKey.UpArrow)
                {
                    if (i == 1)
                        i = quan;
                    else --i;
                }
                if (choise.Key == ConsoleKey.Escape)
                    return _resultInt = 0;
            } while (choise.Key != ConsoleKey.Enter);
            return i;
        }
    }
}
