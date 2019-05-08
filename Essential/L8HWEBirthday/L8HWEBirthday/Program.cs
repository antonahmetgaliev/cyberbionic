using Common;
using System;

namespace L8HWEBirthday
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter the year of your birth - ");
            var birthYear = ConsoleExtension.CheckInt();
            Console.Write("Enter the month of your birth - ");
            var birthMonth = ConsoleExtension.CheckInt();
            Console.Write("Enter the day of your birth - ");
            var birthDay = ConsoleExtension.CheckInt();
        }
    }
}
