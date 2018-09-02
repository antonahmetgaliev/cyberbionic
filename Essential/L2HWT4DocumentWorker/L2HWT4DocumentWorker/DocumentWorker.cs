using System;

namespace L2HWT4DocumentWorker
{
    internal class DocumentWorker
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
}