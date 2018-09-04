namespace L4HWT1AbstractHandler
{
    internal class TxtHandler : AbstractHandler
    {
        public override void Change(string text)
        {
            base.Change(text);
        }

        public override bool Create(string name)
        {
            return base.Create(name+".txt");
        }

        public override bool Open(string name)
        {
            return base.Open(name + ".txt");
        }

        public override void Save()
        {
            base.Save();
        }
    }
}