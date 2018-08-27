using System;

namespace L3HWEPrinter
{
    class Program
    {
        static void Main()
        {
            var print = new PrinterRed();
            print.Print("Hello! (Red)");
            PrinterGreen printUp = print;
            printUp.Print("Hello!! (Green)");
            Printer printUpUp = printUp;
            printUpUp.Print("Hello!!!");
            PrinterGreen printDown = (PrinterGreen)printUpUp;
            printDown.Print("Hello!! (Green)");
            PrinterRed printDownDown = (PrinterRed) printDown;
            printDownDown.Print("Hello! (Red)");
            Console.ReadKey();
        }
    }
}
