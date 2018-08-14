using System;

namespace L1HWT2Rectangle
{
    class Rectangle
    {
        private double side1 = 0;
        private double side2 = 0;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * side1 + 2 * side2;
        }

        public double Area => AreaCalculator();
        public double Perimetr => PerimeterCalculator();
    }
    class Program
    {
        static double Read(string numbstr)
        {
            bool result = int.TryParse(numbstr, out var number);
            Console.WriteLine(result == true ? "Conversion was successful" : "Conversion failed");
            return number;
        }
        static void Main()
        {
            Console.Write("Input side 1 - ");
            double side1 = Read(Console.ReadLine());
            Console.Write("Input side 2 - ");
            double side2 = Read(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area = {0}",rectangle.Area);
            Console.WriteLine("Perimetr = {0}",rectangle.Perimetr);
            Console.ReadKey();
        }
    }
}
