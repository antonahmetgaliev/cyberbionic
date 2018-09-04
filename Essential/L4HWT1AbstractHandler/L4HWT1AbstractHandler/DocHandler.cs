namespace L4HWT1AbstractHandler
{
    internal class DocHandler : AbstractHandler
    {
        public override void Change(string text)
        {
            base.Change(text);
        }

        public override bool Create(string name)
        {
            return base.Create(name + ".doc");
        }

        public override void Open(string name)
        {
            base.Open(name + ".doc");
        }

        public override void Save() { }
    }
}