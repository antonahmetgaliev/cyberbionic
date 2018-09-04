using System;

namespace L2HWT4DocumentWorker
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");
        }
    }
}