using System;
using L5HWT4Article;

namespace L6HWT2FindAndReplaceManager
{
    internal class Program
    {
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

        private static void Start()
        {
            Console.Clear();
            var subMenu = new Menu();
            var subBody = new[]
            {
                "Do you want to enter your string or enter the default string?","New","Default"
            };
            Console.Clear();
            var subSelect = subMenu.CreateMenuStr(subBody);
            switch (subSelect)
            {
                case "New":
                    Console.Write("\nEnter your string - ");
                    var str = Console.ReadLine();
                    FARManager.AddStr(str);
                    break;
                case "Default":
                    str =
                        "Using Visual Studio, create a project using the Console Application template.";
                    FARManager.AddStr(str);
                    break;
            }
            Console.WriteLine("\nDone!");
        }

        private static void Main()
        {
            Start();
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            var menu = new Menu();
            var body = new[]
            {
                "Menu:", "Enter new string", "Find word in string", "Find and Replace word in string","Show string"
            };
            do
            {
                Console.Clear();
                var select = menu.CreateMenuInt(body);
                switch (select)
                {
                    case 1:
                        Start();
                        Done();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter word for find - ");
                        var word = Console.ReadLine();
                        Console.WriteLine(FARManager.FindNext(word) ? $"{word} is in string" : $"No {word} in string");
                        Done();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter word for find - ");
                        var findWord = Console.ReadLine();
                        Console.Write("\nEnter word for replace - ");
                        var replWord = Console.ReadLine();
                        Console.WriteLine(FARManager.ReplaceNext(findWord, replWord) ? "Done!" : "Error!");
                        Done();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("All string:\n");
                        Console.WriteLine(FARManager.Show());
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
