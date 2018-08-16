using System;

namespace L2HWT3Employee
{
    class MenuStr
    {
        private void Color(string str, ref string _result)
        {
            _result = str;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public string CreateMenu(string title, int quan, string body1, string body2, string body3)
        {
            ConsoleKeyInfo choise;
            var i = 0;
            var result = "";
            do
            {
                Console.Clear();
                Console.WriteLine(title);
                switch (i)
                {
                    case 0:
                        Color(body1, ref result);
                        Console.WriteLine(body2);
                        Console.WriteLine(body3);
                        break;
                    case 1:
                        Console.WriteLine(body1);
                        Color(body2, ref result);
                        Console.WriteLine(body3);
                        break;
                    case 2:
                        Console.WriteLine(body1);
                        Console.WriteLine(body2);
                        Color(body3, ref result);
                        break;
                }
                choise = Console.ReadKey();
                if (choise.Key == ConsoleKey.DownArrow)
                {
                    if (i == quan)
                        i = 0;
                    else ++i;
                }
                if (choise.Key == ConsoleKey.UpArrow)
                {
                    if (i == 0)
                        i = quan;
                    else --i;
                }
            } while (choise.Key != ConsoleKey.Enter);
            return result;
        }
        public string CreateMenu(string title, int quan, string body1, string body2, string body3, string body4)
        {
            ConsoleKeyInfo choise;
            var i = 0;
            var result = "";
            do
            {
                Console.Clear();
                Console.WriteLine(title);
                switch (i)
                {
                    case 0:
                        Color(body1, ref result);
                        Console.WriteLine(body2);
                        Console.WriteLine(body3);
                        Console.WriteLine(body4);
                        break;
                    case 1:
                        Console.WriteLine(body1);
                        Color(body2, ref result);
                        Console.WriteLine(body3);
                        Console.WriteLine(body4);
                        break;
                    case 2:
                        Console.WriteLine(body1);
                        Console.WriteLine(body2);
                        Color(body3, ref result);
                        Console.WriteLine(body4);
                        break;
                    case 3:
                        Console.WriteLine(body1);
                        Console.WriteLine(body2);
                        Console.WriteLine(body3);
                        Color(body4, ref result);
                        break;
                }
                choise = Console.ReadKey();
                if (choise.Key == ConsoleKey.DownArrow)
                {
                    if (i == quan)
                        i = 0;
                    else ++i;
                }
                if (choise.Key == ConsoleKey.UpArrow)
                {
                    if (i == 0)
                        i = quan;
                    else --i;
                }
            } while (choise.Key != ConsoleKey.Enter);
            return result;
        }
    }
}
