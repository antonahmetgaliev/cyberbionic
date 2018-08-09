using System;

namespace L5HWETranslate
{
    internal class Program
    {
        private static void Main()
        {
            var dictionary = new Dictionary();
            do
            {
                Console.Write("Enter word - ");
                var word = Console.ReadLine();
                Console.WriteLine(dictionary[word]);
            } while (Try());

            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            
            Console.ReadKey();
        }

        private static bool Try()
        {
            Console.Write("\nDo u want to enter other word? (Y/N)");
            var exit = Console.ReadKey();
            return exit.Key != ConsoleKey.N;
        }
    }
}
