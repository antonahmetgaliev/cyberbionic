using System;

namespace L6HWT3Book
{
    internal static class Menu
    {
        private static string _resultStr;
        private static int _resultInt;

        public static bool Try()
        {
            if (_resultInt == 0 && _resultStr == "exit") return false;
            Console.Write("\nReturn to the previous menu? (Y/N)");
            var exit = Console.ReadKey();
            Console.Clear();
            return exit.Key != ConsoleKey.N;

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
        private static void Show(string str)
        {
            Console.WriteLine("- {0}", str);
        }
        public static string CreateMenuStr(string [] body)
        {
            ConsoleKeyInfo choose;
            var i = 1;
            var quan = body.Length-1;
            _resultStr = "";
            do
            {
                Console.Clear();
                if (body[0]!="") Console.WriteLine(body[0]);
                for (var j = 1; j < body.Length; j++)
                {
                    if (j==i) _resultStr = Color(body[j]);
                    else Show(body[j]);
                }
                Console.WriteLine("\nPress Esc for exit");
                choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.DownArrow when i == quan:
                        i = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ++i;
                        break;
                    case ConsoleKey.UpArrow when i == 1:
                        i = quan;
                        break;
                    case ConsoleKey.UpArrow:
                        --i;
                        break;
                    case ConsoleKey.Escape:
                        _resultInt = 0;
                        return _resultStr="exit";
                }
            } while (choose.Key != ConsoleKey.Enter);
            return _resultStr;
        }
        public static int CreateMenuInt(string[] body)
        {
            ConsoleKeyInfo choose;
            var i = 1;
            var quan = body.Length - 1;
            do
            {
                Console.Clear();
                if (body[0] != "") Console.WriteLine(body[0]);
                for (var j = 1; j < body.Length; j++)
                {
                    if (j == i) Color(body[j]);
                    else Show(body[j]);
                }
                Console.WriteLine("\nPress Esc for exit");
                choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.DownArrow when i == quan:
                        i = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ++i;
                        break;
                    case ConsoleKey.UpArrow when i == 1:
                        i = quan;
                        break;
                    case ConsoleKey.UpArrow:
                        --i;
                        break;
                    case ConsoleKey.Escape:
                        _resultStr = "exit";
                        return _resultInt = 0;
                }
            } while (choose.Key != ConsoleKey.Enter);
            return i;
        }
    }
}
