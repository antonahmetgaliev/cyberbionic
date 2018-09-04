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
            Console.Clear();
            Console.Write("Enter name of file - ");
            var nameOfFile = Console.ReadLine();
            file.Create(nameOfFile);
            file.Open(nameOfFile);
            Console.Write("Enter new text in your document - ");
            var text = Console.ReadLine();
            file.Change(text);
            file.Save();
        }
    }
}
