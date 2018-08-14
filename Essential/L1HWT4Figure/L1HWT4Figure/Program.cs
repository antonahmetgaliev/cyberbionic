using System;

namespace L1HWT4Figure
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Figure();
            Console.Write("Input name of figure - ");
            figure.InitFigure(Console.ReadLine());
            Console.WriteLine("Perimetr of ur figere {0} = {1} sm", figure.Name, figure.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
