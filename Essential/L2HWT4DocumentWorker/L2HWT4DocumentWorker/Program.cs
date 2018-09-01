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
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

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
        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");
        }
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
