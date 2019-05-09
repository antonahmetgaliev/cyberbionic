using System;
using Common;

namespace L8HWT2PrintColor
{
    internal class Program
    {
        private static readonly string[] Body =
        {
            "Select the desired color:",
            "black",
            "darkBlue",
            "darkGreen",
            "darkCyan",
            "darkRed",
            "darkMagenta",
            "darkYellow",
            "gray",
            "darkGray",
            "blue",
            "green",
            "cyan",
            "red",
            "magenta",
            "yellow",
            "white"
        };

        private static void Main()
        {
            Console.Write("Enter your string - ");
            var str = Console.ReadLine();
            PrintColor.Print(str, Menu.CreateMenuIntWithoutEsc(Body));
            Console.ReadKey();
        }
    }
}
