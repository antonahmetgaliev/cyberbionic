﻿using System;

namespace L1HWT3Book
{
    class Title
    {
        public string Content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}