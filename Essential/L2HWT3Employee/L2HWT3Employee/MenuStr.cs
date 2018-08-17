﻿using System;

namespace L2HWT3Employee
{
    class MenuStr
    {
        private string Color(string str)
        {
            Console.BackgroundColor = ConsoleColor.White;
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
        public string CreateMenu(string [] body)
        {
            ConsoleKeyInfo choise;
            var i = 1;
            var quan = body.Length-1;
            var result = "";
            do
            {
                Console.Clear();
                Console.WriteLine(body[0]);
                for (int j = 1; j < body.Length; j++)
                {
                    if (j==i) result = Color(body[j]);
                    else Show(body[j]);
                }
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
            } while (choise.Key != ConsoleKey.Enter);
            return result;
        }
    }
}
