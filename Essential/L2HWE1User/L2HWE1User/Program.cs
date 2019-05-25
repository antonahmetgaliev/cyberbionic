using System;

namespace L2HWE1User
{
    internal class Program
    {
        private static bool Continue()
        {
            Console.Write("Would you like to continue? (y/n) - ");
            var choose = Console.ReadLine();
            Console.Clear();
            return choose != "y";
        }

        private static void Main()
        {
            var id = -1;
            Console.Write("Input date of completion (Day.Month.Year)");
            var date = Console.ReadLine();
            var newUser = new Data(date);
            var error = false;
            do
            {
                Console.Write("Create new User or Show? (n/s)");
                var choose = Console.ReadLine();
                switch (choose)
                {
                    case "n":
                    {
                        Console.Write("Input login - ");
                        var login = Console.ReadLine();
                        Console.Write("Input name of user - ");
                        var name = Console.ReadLine();
                        Console.Write("Surname of user - ");
                        var surname = Console.ReadLine();
                        Console.Write("Age of user - ");
                        var age = Console.ReadLine();
                        ++id;
                        newUser.InputUser(login, name, surname, age, id);
                        error=Continue();
                        break;
                    }
                    case "s":
                    {
                        Console.Write("Input id of User - ");
                        var idSearch = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                        if (idSearch != -1)
                        {
                            if (idSearch > id)
                            {
                                Console.WriteLine("User not found!");
                                break;
                            }
                            newUser.ShowUser(id);
                            error=Continue();
                            break;
                        }
                        Console.WriteLine("Error! Users list is empty");
                        break;

                    }
                    default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }

                }
            } while (!error);
        }
    }
}
