using System;

namespace L2HWT3Employee
{
    internal class Program
    {
        private static void StandardWorkers(Employee employee)
        {
            employee.NewWorker("Michael", "Watkins", "director", 20);
            employee.NewWorker("Brittany", "Riley", "accountant", 13);
            employee.NewWorker("William", "Pitts", "employee", 3);
            employee.NewWorker("Jayson", "Collins", "employee", 35);
            employee.NewWorker("Gavin", "Floyd", "employee", 15);
        }

        private static bool CheckDoub(string str)
        {
            var check = double.TryParse(str, out _);
            return check;
        }

        private static bool Director(Employee employee, int doit)
        {
            Console.Write("Do u want to change? (Y/N)");
            var check = Console.ReadKey();
            if (check.Key != ConsoleKey.Y) return true;
            string str;
            do
            {
                Console.Write("\nInput new value - ");
                str = Console.ReadLine();
                if (!CheckDoub(str)) Console.WriteLine("Enter error!");
            } while (!CheckDoub(str));
            var value = double.Parse(str ?? throw new InvalidOperationException());
            if (doit == 1)
                employee.Salary(value);
            else if (doit == 2)
                employee.DirPer(value);
            else if (doit == 3)
                employee.AccPer(value);
            else if (doit == 4) employee.EmpPer(value);

            Console.Write("Do u want return to menu? (Y/N)");
            check = Console.ReadKey();
            return check.Key == ConsoleKey.Y;
        }

        private static void ShowSalary(Employee employee, int counter)
        {
            Console.WriteLine("\nName : {0}", employee.ShowName(counter));
            Console.WriteLine("Surname : {0}", employee.ShowSurname(counter));
            Console.WriteLine("Position : {0}", employee.ShowPosition(counter));
            Console.WriteLine("Experience : {0}", employee.ShowExperience(counter));
            Console.WriteLine("Salary : {0} USD", employee.ShowSalary(counter));
            Console.WriteLine("The amount of the tax charge : {0} USD", employee.ShowTax(counter));
        }
        static void Main()
        {
            var jobs = 5;
            var menu = new Menu();
            bool levelCheck;
            do
            {
                string acces;
                do
                {
                    levelCheck = false;
                    string[] body = {"Select your access level", "director", "accountant", "employee"};
                    acces = menu.CreateMenuStr(body);
                    if (acces == "exit") Environment.Exit(0);
                    bool accesCheck;
                    do
                    {
                        Console.Clear();
                        Console.Write("Enter password of your access - ");
                        var password = Console.ReadLine();
                        if (accesCheck = (acces != password))
                        {
                            Console.Write("Access error!Do u want to change acces level? (Y/N)");
                            var check = Console.ReadKey();
                            if (check.Key != ConsoleKey.Y) continue;
                            accesCheck = false;
                            levelCheck = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hello {0}!", acces);
                        }
                    } while (accesCheck);
                } while (levelCheck);

                var employee = new Employee();
                StandardWorkers(employee);
                int doit;
                switch (acces)
                {
                    case "director":
                        var exit = true;
                        do
                        {
                            string[] body =
                            {
                                "What do you want to do?", "Change all salary",
                                "Change salary to the director", "Change salary to the accountant",
                                "Change salary to the employee", "Show all workers", "Add new worker",
                                "Change acces level"
                            };
                            doit = menu.CreateMenuInt(body);
                            switch (doit)
                            {
                                case 1:
                                    bool dirCheck;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The salary constant is now {0} USD",
                                            employee.Salary());
                                        dirCheck = Director(employee, doit);
                                    } while (!dirCheck);

                                    break;
                                case 2:
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Now the percentage of the director is {0}%",
                                            employee.DirPer());
                                        dirCheck = Director(employee, doit);
                                    } while (!dirCheck);

                                    break;
                                case 3:
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Now the percentage of the accountant is {0}%",
                                            employee.AccPer());
                                        dirCheck = Director(employee, doit);
                                    } while (!dirCheck);

                                    break;
                                case 4:
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Now the percentage of the employee is {0}%",
                                            employee.EmpPer());
                                        dirCheck = Director(employee, doit);
                                    } while (!dirCheck);

                                    break;
                                case 5:
                                    var check = true;
                                    do
                                    {
                                        Console.Clear();
                                        var k = 0;
                                        for (var i = 0; i < jobs; i++)
                                        {
                                            if (k < 21)
                                            {
                                                ShowSalary(employee, i);
                                                k += 7;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPress any key to continue");
                                                Console.ReadKey();
                                                Console.Clear();
                                                k = 0;
                                                ShowSalary(employee, i);
                                                k += 7;
                                            }
                                        }

                                        Console.Write("\nDo u want return to menu? (Y/N)");
                                        var _exit = Console.ReadKey();
                                        if (_exit.Key == ConsoleKey.Y) check = false;
                                    } while (check);

                                    break;
                                case 6:
                                    check = true;
                                    do
                                    {
                                        Console.Clear();
                                        Console.Write("Input Name of new worker - ");
                                        var name = Console.ReadLine();
                                        Console.Write("Input Surname of new worker - ");
                                        var surname = Console.ReadLine();
                                        Console.Write("Input Position of new worker - ");
                                        var position = Console.ReadLine();
                                        string str;
                                        do
                                        {
                                            Console.Write("Input experience of new worker - ");
                                            str = Console.ReadLine();
                                            if (!CheckDoub(str)) Console.WriteLine("Enter error!");
                                        } while (!CheckDoub(str));
                                        var experience = double.Parse(str);
                                        if (employee.NewWorker(name, surname, position, experience))
                                        {
                                            Console.WriteLine("Worker successfully added!");
                                            jobs++;
                                        }
                                        else Console.WriteLine("All jobs are occupied!");
                                        Console.Write("\nDo u want return to menu? (Y/N)");
                                        var _exit = Console.ReadKey();
                                        if (_exit.Key == ConsoleKey.Y) check = false;
                                    } while (check);
                                    break;
                                case 7:
                                    exit = false;
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (exit);

                        break;
                    case "accountant":
                        exit = true;
                        do
                        {
                            string[] body =
                            {
                                "What do you want to do?", "Change salary to the employee",
                                "Show accountant and employe salary", "Change acces level"
                            };
                            doit = menu.CreateMenuInt(body);
                            switch (doit)
                            {
                                case 1:
                                    bool dirCheck;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Now the percentage of the employee is {0}%",
                                            employee.EmpPer());
                                        dirCheck = Director(employee, doit);
                                    } while (!dirCheck);

                                    break;
                                case 2:
                                    var check = true;
                                    do
                                    {
                                        Console.Clear();
                                        var k = 0;
                                        for (var i = 0; i < jobs; i++)
                                        {
                                            if (k < 21)
                                            {
                                                ShowSalary(employee, i);
                                                k += 7;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPress any key to continue");
                                                Console.ReadKey();
                                                Console.Clear();
                                                k = 0;
                                                ShowSalary(employee, i);
                                                k += 7;
                                            }
                                        }

                                        Console.Write("\nDo u want return to menu? (Y/N)");
                                        var _exit = Console.ReadKey();
                                        if (_exit.Key == ConsoleKey.Y) check = false;
                                    } while (check);

                                    break;
                                case 3:
                                    exit = false;
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (exit);

                        break;
                    case "employee":
                        Console.Clear();
                        var clear = 0;
                        for (var i = 0; i < jobs; i++)
                        {
                            if (clear < 21)
                            {
                                ShowSalary(employee, i);
                                clear += 7;
                            }
                            else
                            {
                                Console.WriteLine("\nPress any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                                clear = 0;
                                ShowSalary(employee, i);
                                clear += 7;
                            }
                        }
                        Console.ReadKey();
                        break;
            }
            } while (!levelCheck);
        }
    }
}
