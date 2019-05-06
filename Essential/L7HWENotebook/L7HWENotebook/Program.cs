using Common;
using System;

namespace L7HWENotebook
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter model of notebook - ");
            var model = Console.ReadLine();
            Console.Write("Enter manufacturer of notebook - ");
            var manufacturer = Console.ReadLine();
            Console.Write("Enter price of notebook - ");
            var price = ConsoleExtension.CheckInt();
            var notebook = new Notebook(model, manufacturer, price);
            Console.WriteLine("Notebook:");
            Console.WriteLine($"Model: {notebook.Model}");
            Console.WriteLine($"Manufacturer: {notebook.Manufacturer}");
            Console.WriteLine($"Price: {notebook.Price} UAH");
            Console.ReadKey();
        }
    }
}
