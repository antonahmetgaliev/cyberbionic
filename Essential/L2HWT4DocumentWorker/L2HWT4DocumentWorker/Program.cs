using System;

namespace L2HWT4DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The document is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Editing the document is available in the Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in the Pro version");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document has been edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in the remaining formats is available in the Expert version");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");
        }
    }
    class Program
    {
        static void Main()
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
