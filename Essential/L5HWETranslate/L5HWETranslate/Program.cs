using System;

namespace L5HWETranslate
{
    internal class Dictionary
    {
        private readonly string[] _key = new string[5];
        private readonly string[] _keyUkr = new string[5];
        private readonly string[] _value = new string[5];

        public Dictionary()
        {
            _key[0] = "книга"; _value[0] = "book"; _keyUkr[0] = "книга";
            _key[1] = "ручка"; _value[1] = "pen"; _keyUkr[1] = "ручка";
            _key[2] = "солнце"; _value[2] = "sun"; _keyUkr[2] = "сонце";
            _key[3] = "яблоко"; _value[3] = "apple"; _keyUkr[3] = "яблуко";
            _key[4] = "стол"; _value[4] = "table"; _keyUkr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (var i = 0; i < _key.Length; i++)
                {
                    if (_key[i] == index)
                        return _key[i] + " - " + _value[i] + " - " + _keyUkr[i];
                    if (_value[i] == index)
                        return _key[i] + " - " + _value[i] + " - " + _keyUkr[i];
                    if (_keyUkr[i] == index)
                        return _key[i] + " - " + _value[i] + " - " + _keyUkr[i];
                }
                return $"{index} - нет перевода для этого слова.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _key.Length)
                    return _key[index] + " - " + _value[index];
                return "Попытка обращения за пределы массива.";
            }
        }
    }

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
