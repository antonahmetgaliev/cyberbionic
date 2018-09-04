using System;

namespace L4HWT1AbstractHandler
{
    internal class Program
    {
        private static void Main()
        {
            var menu = new Menu();
            do
            {
                var body = new[]
                {
                    "Select document type", "XML", "TXT", "DOC"
                };
                var select = menu.CreateMenuStr(body);
                AbstractHandler file;
                switch (select)
                {
                    case "XML":
                        file = new XmlHandler();
                        WorkWithDocument(file);
                        break;
                    case "TXT":
                        file = new TxtHandler();
                        WorkWithDocument(file);
                        break;
                    case "DOC":
                        file = new DocHandler();
                        WorkWithDocument(file);
                        break;
                }
            } while (menu.Try());
        }

        private static void WorkWithDocument(AbstractHandler file)
        {
            var menu = new Menu();
            string nameOfFile=null;
            do
            {
                Console.Clear();
                string [] body;
                if (!file.Open(nameOfFile))
                {
                    body = new[]
                    {
                        "Select your choice:", "Create new file", "Open and read file"
                    };
                }
                else
                {
                    body = new[]
                    {
                        "Select your choice:", "Create new file", "Open and read file", "Change file", "Save file"
                    };
                }
                var select = menu.CreateMenuInt(body);
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter name of file - ");
                        nameOfFile = Console.ReadLine();
                        Console.WriteLine(file.Create(nameOfFile)
                            ? "New file created!"
                            : "File with this name already exists.");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter name of file - ");
                        nameOfFile = Console.ReadLine();
                        Console.WriteLine(file.Open(nameOfFile)
                            ? "File successfully opened!"
                            : "A file with this name was not found!");
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter new text in your document - ");
                        var text = Console.ReadLine();
                        file.Change(text);
                        Console.WriteLine("File successfully changed!");
                        break;
                    case 4:
                        Console.Clear();
                        file.Save();
                        Console.WriteLine("File successfully saved!");
                        break;
                }
                Console.Clear();
            } while (menu.Try());
        }
    }
}
