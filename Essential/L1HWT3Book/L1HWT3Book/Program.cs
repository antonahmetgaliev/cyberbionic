using System;

namespace L1HWT3Book
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Input name of book - ");
            var name = Console.ReadLine();
            Console.Write("Input name of Author - ");
            var author = Console.ReadLine();
            Console.Write("Input content - ");
            var content = Console.ReadLine();
            var book = new Book(name)
            {
                Author = author,
                Content = content
            };
            book.Show();
            Console.ReadKey();
        }
    }
}
