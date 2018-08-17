using System;

namespace L2HWT3Employee
{
    class Program
    {
        static bool Try()
        {
            Console.Write("Do u want to try again? (Y/N)");
            var check = Console.ReadKey();
            Console.Clear();
            return check.Key == ConsoleKey.Y;
        }
        
        static void Main()
        {
            //do
            //{
            //    Console.Write("Input name od worker - ");
            //    var name = Console.ReadLine();
            //    Console.Write("Input surname od worker - ");
            //    var surname = Console.ReadLine();
            //    var posCheck = false;
            //    string position;
            //    do
            //    {
            //        Console.Write("Input position od worker (accountant,security,director)- ");
            //        position = Console.ReadLine();
            //        if (position != "accountant" && position != "security" && position != "director")
            //            Console.WriteLine("Error of position entry!");
            //        else posCheck = true;
            //    } while (!posCheck);

            //    Console.Write("Input experience of worker - ");
            //    var experience = double.Parse(Console.ReadLine());
            //    var employee = new Employee(name, surname);
            //    var salary = employee.Salary(position, experience);
            //    employee.Show(salary);
            //} while (Try());
            //////////////////////////////////
            //bool accesCheck;
            //var acces = "";
            //do
            //{
            //    Console.Clear();
            //    Console.Write("Enter your access level (direcor, accountant, employee)");
            //    acces = Console.ReadLine();
            //    Console.Write("Enter password of your access - ");
            //    var password = Console.ReadLine();
            //    if (accesCheck = (acces != password))
            //    {
            //        Console.WriteLine("Access error!");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Hello {0}", acces);
            //    }
            //} while (!accesCheck);
            string acces;
            var menu = new Menu();
            bool levelCheck;
            do
            {
                levelCheck = false;
                string[] body = {"Select your access level", "director", "accountant", "employee"};
                acces = menu.CreateMenuStr(body);
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

            switch (acces)
            {
                case "director":
                    string[] body =
                    {
                        "What do you want to do?",
                        "Change salary to the director", "Change salary to the accountant",
                        "Change salary to the employee", "Show all salary"
                    };
                    var doit = menu.CreateMenuInt(body);
                    switch (doit)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:break;
                    }
                    break;
                case "accountant":
                    string[] body2 =
                    {
                        "What do you want to do?", "Change salary to the employee",
                        "Show accountant and employe salary"
                    };
                    doit = menu.CreateMenuInt(body2);
                    break;
                case "employe": break;
            }

            Console.WriteLine("!!!!");
            Console.ReadKey();
        }
    }
}
