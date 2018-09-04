namespace L4HWT1AbstractHandler
{
    internal class XmlHandler : AbstractHandler
    {
        public override void Change(string text)
        {
            base.Change(text);
        }

        public override bool Create(string name)
        {
            return base.Create(name + ".xml");
        }

        public override bool Open(string name)
        {
            return base.Open(name + ".xml");
        }

        public override void Save()
        {
            base.Save();
        }
    }
}