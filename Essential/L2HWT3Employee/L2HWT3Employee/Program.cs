using System;

namespace L2HWT3Employee
{
    class Program
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
            if (check.Key == ConsoleKey.Y)
            {
                string str;
                do
                {
                    Console.Write("\nInput new value - ");
                    str = Console.ReadLine();
                    if (!CheckDoub(str)) Console.WriteLine("Enter error!");
                } while (!CheckDoub(str));
                var value = double.Parse(str);
                switch (doit)
                {
                    case 1:
                        employee.Salary(value);
                        break;
                    case 2:
                        employee.DirPer(value);
                        break;
                    case 3:
                        employee.AccPer(value);
                        break;
                    case 4:
                        employee.EmpPer(value);
                        break;
                }
                Console.Write("Do u want return to menu? (Y/N)");
                check = Console.ReadKey();
                if (check.Key == ConsoleKey.Y) return true;
                return false;
            }
            return true;
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
            string acces;
            var menu = new Menu();
            bool levelCheck;
            do
            {
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
                            if (check.Key == ConsoleKey.Y)
                            {
                                accesCheck = false;
                                levelCheck = true;
                            }
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
                                "Change salary to the employee", "Show all workers",
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
                                        for (int i = 0; i < 5; i++)
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
                                    exit = false;
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (exit);

                        break;
                    case "accountant":
                        string[] body2 =
                        {
                            "What do you want to do?", "Change salary to the employee",
                            "Show accountant and employe salary", "Change acces level"
                        };
                        doit = menu.CreateMenuInt(body2);
                        break;
                    case "employe": break;
                }
            } while (!levelCheck);
        }
    }
}
