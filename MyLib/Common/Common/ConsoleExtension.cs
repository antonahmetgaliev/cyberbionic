using System;

namespace Common
{
    public static class ConsoleExtension
    {
        public static int CheckInt()
        {
            int value;
            var text = Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }
            return value;
        }
        public static double CheckDouble()
        {
            double value;
            var text = Console.ReadLine();
            while (!double.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }
        public static void WaitingAction()
        {
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadKey();
        }
    }
}
