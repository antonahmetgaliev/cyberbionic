using System;

namespace L1HWT4Figure
{
    internal class Program
    {
        private static int CheckInt()
        {
            int value;
            var text= Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }

        private static bool Try()
        {
            Console.Write("Do u want to try again? (Y/N)");
            var check = Console.ReadKey();
            Console.Clear();
            return check.Key == ConsoleKey.Y;
        }
        private static void Main()
        {
            do
            {
                var figure = new Figure.Figure();
                Console.Write("Input name of figure - ");
                var name = Console.ReadLine();
                figure.InitFigure(name);
                Console.Write("Input number of points - ");
                var number = CheckInt();
                for (var i = 0; i < number; i++)
                {
                    Console.Write("\nInput X - ");
                    var x = CheckInt();
                    Console.Write("Input Y - ");
                    var y = CheckInt();
                    figure.InputPoint(Convert.ToString(i), x, y);
                }
                Console.WriteLine("Perimetr of ur figure {0} = {1} sm", figure.Name, figure.PerimeterCalculator());
            } while (Try());
        }
    }
}
