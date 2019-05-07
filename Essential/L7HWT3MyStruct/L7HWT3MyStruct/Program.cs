using System;

namespace L7HWT3MyStruct
{
    internal class Program
    {
        private static void ClassTaker(MyClass myClass)
        {
            myClass.Change("Changed");
        }

        private static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change("Changed");
        }

        private static void Main()
        {
            var myClass = new MyClass("No changed");
            var myStruct = new MyStruct("No changed");
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadKey();
        }
    }
}
