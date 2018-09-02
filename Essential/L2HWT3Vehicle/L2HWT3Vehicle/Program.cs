using System;
using System.Collections.Generic;
using L2HWT3Employee;

namespace L2HWT3Vehicle
{
    internal class Program
    {
        private static double CheckDouble()
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

        private static int CheckInt()
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

        private static void Main()
        {
            var menu = new Menu();
            var exit = true;
            var vehicles = new List<Vehicle>();
            do
            {
                string[] body =
                {
                    "What you wnat to do?", "Add new Plane", "Add new Ship", "Add new Car",
                    "Show info about all vehicle"
                };
                var switchOfMenu = menu.CreateMenuInt(body);
                switch (switchOfMenu)
                {
                    case 1:
                        EnterParam(out var price, out var speed, out var year, out var number);
                        Console.Write("Enter height - ");
                        var height = CheckDouble();
                        vehicles.Add(new Plane(number, height, price, speed, year));
                        exit = Try();
                        break;
                    case 2:
                        EnterParam(out price, out speed, out year, out number);
                        Console.Write("Enter port of recidence - ");
                        var port = Console.ReadLine();
                        vehicles.Add(new Ship(number, port, price, speed, year));
                        exit = Try();
                        break;
                    case 3:
                        EnterCarParam(out price, out speed, out year);
                        Console.Write("Enter location - ");
                        var location = Console.ReadLine();
                        vehicles.Add(new Car(location, price, speed, year));
                        exit = Try();
                        break;
                    case 4:
                        Console.Clear();
                        foreach (var show in vehicles)
                        {
                            Console.WriteLine(show.ShowInfo());
                        }
                        exit = Try();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (exit);
        }

        private static void EnterParam(out double price, out double speed, out string year, out int number)
        {
            EnterCarParam(out price, out speed, out year);
            Console.Write("Enter number of pasanger - ");
            number = CheckInt();
        }

        private static void EnterCarParam(out double price, out double speed, out string year)
        {
            Console.Clear();
            Console.Write("\nEnter price - ");
            price = CheckDouble();
            Console.Write("Enter max speed - ");
            speed = CheckDouble();
            Console.Write("Enter year - ");
            year = Console.ReadLine();
        }

        private static bool Try()
        {
            Console.Write("\nDo u want return to menu? (Y/N)");
            var exit = Console.ReadKey();
            return exit.Key != ConsoleKey.N;
        }
    }
}
