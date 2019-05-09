using System;

namespace L8HWT2PrintColor
{
    public static class PrintColor
    {
        public static void Print(string str, int color)
        {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(str);
        }

        public enum Color : int
        {
            black,
            darkBlue,
            darkGreen,
            darkCyan,
            darkRed,
            darkMagenta,
            darkYellow,
            gray,
            darkGray,
            blue,
            green,
            cyan,
            red,
            magenta,
            yellow,
            white
        }
    }
}