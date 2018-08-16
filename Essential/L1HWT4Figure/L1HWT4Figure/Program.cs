using System;

namespace L1HWT4Figure
{
    class Program
    {
        private static bool CheckInt(string str)
        {
            var check = int.TryParse(str, out _);
            return check;
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
                var figure = new Figure();
                Console.Write("Input name of figure - ");
                var name = Console.ReadLine();
                bool check;
                var number = 0;
                do
                {
                    Console.Write("Input the number of points - ");
                    var str = Console.ReadLine();
                    if (check = CheckInt(str))
                    {
                        number = int.Parse(str);
                    }
                    else Console.WriteLine("Input error!");
                } while (!check);
                figure.InitFigure(name, number);
                for (var i = 0; i < number; i++)
                {
                    Console.Write("Input letter of point - ");
                    var letter = Console.ReadLine();
                    int x = 0, y = 0;
                    do
                    {
                        Console.Write("Input X - ");
                        var str = Console.ReadLine();
                        if (check = CheckInt(str))
                        {
                            x = int.Parse(str);
                            Console.Write("Input Y - ");
                            str = Console.ReadLine();
                            if (check = CheckInt(str))
                            {
                                y = int.Parse(str);
                            }
                            else Console.WriteLine("Input error!");
                        }
                        else Console.WriteLine("Input error!");
                    } while (!check);

                    figure.InputPoint(letter, x, y, i);
                }
                Console.WriteLine("Perimetr of ur figere {0} = {1} sm", figure.Name, figure.PerimeterCalculator());
            } while (Try());
        }
    }
}
