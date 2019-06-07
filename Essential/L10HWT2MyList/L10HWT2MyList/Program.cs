using System;
using System.Collections.Generic;

namespace L10HWT2MyList
{
    internal class Program
    {
        private static void Main()
        {
            var list = new MyList<int>();
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            int[] array;
            array = list.GetArray();
            for (var i = 0; i < array.Lenght; i ++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey;
        }
    }
}
