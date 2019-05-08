using Common;
using System;

namespace L8HWEBirthday
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter the month of your birth - ");
            var birthMonth = ConsoleExtension.CheckInt();
            Console.Write("Enter the day of your birth - ");
            var birthDay = ConsoleExtension.CheckInt();
            var today = DateTime.Now;
            int leftYear;
            if (today.Month > birthMonth) leftYear = today.Year;
            else leftYear = today.Year + 1;
            var birthday = new DateTime(leftYear, birthMonth, birthDay);
            var left = birthday - today;

        }
    }
}
