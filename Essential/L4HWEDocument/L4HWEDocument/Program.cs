using System;

namespace L4HWEDocument
{
    internal class Program
    {
        private static void Main()
        {
            var title = new Title {Content = "Контракт"};

            var body = new Body {Content = "Тело контракта..."};

            var footer = new Footer {Content = "Директор: Иванов И.И."};

            var document = new Document(title, body, footer);
            document.Show();

            Console.ReadKey();
        }
    }
}
