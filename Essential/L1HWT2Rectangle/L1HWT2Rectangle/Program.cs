using System;

namespace L1HWT2Rectangle
{
    internal class Rectangle
    {
        private readonly double _side1;
        private readonly double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * _side1 + 2 * _side2;
        }

        public double Area => AreaCalculator();
        public double Perimetr => PerimeterCalculator();
    }

    internal class Program
    {
        private static double Read(string numbstr)
        {
            var result = int.TryParse(numbstr, out var number);
            Console.WriteLine(result == true ? "Conversion was successful" : "Conversion failed");
            return number;
        }

        private static void Main()
        {
            Console.Write("Input side 1 - ");
            var side1 = Read(Console.ReadLine());
            Console.Write("Input side 2 - ");
            var side2 = Read(Console.ReadLine());
            var rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area = {0}",rectangle.Area);
            Console.WriteLine("Perimetr = {0}",rectangle.Perimetr);
            Console.ReadKey();
        }
    }
}
