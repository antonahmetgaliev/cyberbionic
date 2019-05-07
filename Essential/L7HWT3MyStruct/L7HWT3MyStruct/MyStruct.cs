namespace L7HWT3MyStruct
{
    internal struct MyStruct
    {
        public string change; // Requirement task conditions.

        public MyStruct(string str)
        {
            change = str;
        }

        public void Change(string str)
        {
            change = str;
        }
    }
}