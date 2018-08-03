using System;

namespace L4HWT0_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Какая погода сегодня?(Введите '?' для подсказки)");
            string wt = Console.ReadLine();
            string chs;
            switch (wt)
            {
                case "?":
                    Console.WriteLine("(Хорошая,Плохая,Нормальная,Солнечная,Облачная,Дождь,Ливень,Гроза,Снегопад,Град");
                    goto Start;
                case "Хорошая":
                    Console.WriteLine("{0} =  Good.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Плохая":
                    Console.WriteLine("{0} =  Bad.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Нормальная":
                    Console.WriteLine("{0} =  Normal.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Солнечная":
                    Console.WriteLine("{0} =  Solar.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Облачная":
                    Console.WriteLine("{0} =  Cloudy.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Дождь":
                    Console.WriteLine("{0} =  Rain.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Ливень":
                    Console.WriteLine("{0} =  Downpour.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Гроза":
                    Console.WriteLine("{0} =  Storm.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Снегопад":
                    Console.WriteLine("{0} =  Snowfall.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                case "Град":
                    Console.WriteLine("{0} =  Hailstones.", wt);
                    Console.Write("Желаете продолжить?(Да/Нет) ");
                    chs = Console.ReadLine();
                    if (chs == "Нет") break;
                    else
                    {
                        Console.WriteLine();
                        goto Start;
                    }
                default:
                    Console.WriteLine("Не правильныый ввод, пожалуйста, повторите попытку");
                    Console.WriteLine();
                    goto Start;
            }           
        }
    }
}
