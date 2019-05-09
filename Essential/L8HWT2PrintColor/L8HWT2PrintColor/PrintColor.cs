using System;

namespace L8HWT2PrintColor
{
    public static class PrintColor
    {
        public static void Print(string str, int color)
        {
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(str);
        }

        private enum Color : int
        {
            blue = ConsoleColor.Blue,
            red = ConsoleColor.Red

        }
    }
}