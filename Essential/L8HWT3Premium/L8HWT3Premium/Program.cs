using System;
using Common;

namespace L8HWT3Premium
{
    internal class Program
    {
        private static void Main()
        {
            var body = new[]
            {
                "Select your position : ", "Worker", "Accountant", "Manager"
            };
            var workerId = Menu.CreateMenuIntWithoutEsc(body);
            Console.Write("\nHow many hours did you work in the last month? - ");
            var hours = ConsoleExtension.CheckInt();
            switch (workerId)
            {
                case 0:
                    ShowBonus(Accountant.Post.Worker, hours);
                    break;
                case 1:
                    ShowBonus(Accountant.Post.Accountant, hours);
                    break;
                case 2:
                    ShowBonus(Accountant.Post.Manager, hours);
                    break;
            }

            Console.ReadKey();
        }

        private static void ShowBonus(Accountant.Post worker, int hours)
        {
            Console.WriteLine(Accountant.AskForBonus(worker, hours)
                ? "\nCongratulations! You have a bonus!"
                : "\nWasted. You have not received a bonus.");
        }
    }
}
