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

        private static void Done()
        {
            Console.WriteLine("\nPress any button to return to the menu.");
            Console.ReadKey();
        }

        private static void Error(string products)
        {
            if (products != "Error")
            {
                Console.WriteLine(products);
                Done();
            }
            else
            {
                Console.WriteLine("Error!");
                Done();
            }
        }

        private static void Main()
        {
            var menu = new Menu();
            var shopStore = new Store();
            var body = new[]
            {
                "Menu:", "Input product", "Search product by index", "Search product by name","Show all products"
            };
            do
            {
                Console.Clear();
                var select = menu.CreateMenuInt(body);
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("how many products you want to add - ");
                        var number = CheckInt();
                        for (var i = 0; i < number; i++)
                        {
                            Console.WriteLine($"\nProduct №{i+1}:");
                            Console.Write("Enter name of product - ");
                            var productName = Console.ReadLine();
                            Console.Write("Enter name of shop - ");
                            var shopName = Console.ReadLine();
                            Console.Write("Enter the cost of product - ");
                            var cost = CheckInt();
                            shopStore.EnterValues(productName, shopName, cost);
                        }
                        Done();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\nEnter index of product - ");
                        var index = CheckInt();
                        var products = shopStore.SearchByIndex(index-1);
                        Error(products);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\nEnter name of product - ");
                        var name = Console.ReadLine();
                        products = shopStore.SearchByName(name);
                        Error(products);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("All products:");
                        var listOfProducts = shopStore.ShowProducts();
                        foreach (var t in listOfProducts)
                        {
                            Console.WriteLine(t);
                        }
                        Done();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (true);

        }
    }
}
