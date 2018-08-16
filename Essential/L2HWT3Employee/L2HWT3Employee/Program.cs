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
            var menuStr = new MenuStr();
            var menuInt = new MenuInt();
            bool levelCheck;
            do
            {
                levelCheck = false;
                acces = menuStr.CreateMenu("Select your access level", 2, "director", "accountant", "employee");
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
                    var doit = menuInt.CreateMenu("What do you want to do?", 3,
                        "Change salary to the director" ,"Change salary to the accountant", 
                        "Change salary to the employee", "Show all salary");
                    break;
                case "accountant":
                    doit = menuInt.CreateMenu("What do you want to do?", 1,
                        "Change salary to the employee", "Show accountant and employe salary");
                    break;
                default: break;
            }

            Console.WriteLine("!!!!");
            Console.ReadKey();
        }
    }
}
