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
            do
            {
                Console.Write("Input name od worker - ");
                var name = Console.ReadLine();
                Console.Write("Input surname od worker - ");
                var surname = Console.ReadLine();
                var posCheck = false;
                string position;
                do
                {
                    Console.Write("Input position od worker (accountant,security,director)- ");
                    position = Console.ReadLine();
                    if (position != "accountant" && position != "security" && position != "director")
                        Console.WriteLine("Error of position entry!");
                    else posCheck = true;
                } while (!posCheck);

                Console.Write("Input experience of worker - ");
                var experience = double.Parse(Console.ReadLine());
                var employee = new Employee(name, surname);
                var salary = employee.Salary(position, experience);
                employee.Show(salary);
            } while (Try());
        }
    }
}
