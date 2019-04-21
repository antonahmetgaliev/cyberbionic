using System;

namespace L5HWT4Article
{
    internal class Program
    {
        private static int CheckInt()
        {
            int value;
            var text = Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }

        private static void Main()
        {
            var menu = new Menu();
            var body = new[]
            {
                "Menu:", "Input product", "Search product by index", "Search product by name","Search product by index", "Exit"
            };
            do
            {
                var select = menu.CreateMenuInt(body);
                switch (select)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (true);

        }
    }
}
