using System;

namespace L2HWT4DocumentWorker
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter your pin - ");
            var pin = Console.ReadLine();
            switch (pin)
            {
                case "Expert":
                    var expDocument = new ExpertDocumentWorker();
                    DocumentWorker document = expDocument;
                    ShowMetods(document, "expert");
                    break;
                case "Pro":
                    var proDocument = new ProDocumentWorker();
                    document = proDocument;
                    ShowMetods(document, "pro");
                    break;
                default:
                    document = new DocumentWorker();
                    ShowMetods(document, "user");
                    break;
            }
            Console.ReadKey();
        }

        private static void ShowMetods(DocumentWorker document, string access)
        {
            Console.WriteLine($"You are logged in as an {access}.\n");
            Console.Clear();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
