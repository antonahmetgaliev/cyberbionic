using System;

namespace L2HWT4DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
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
}