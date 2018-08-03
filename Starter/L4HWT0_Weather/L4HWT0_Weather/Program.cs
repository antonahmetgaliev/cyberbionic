using System;

namespace L4HWT0_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Какая погода сегодня?(Введите '?' для подсказки)");
                string WeatherToday = Console.ReadLine();
                switch (WeatherToday)
                {
                    case "?":
                        Console.WriteLine("Хорошая,Плохая,Нормальная,Солнечная,Облачная,Дождь,Ливень,Гроза,Снегопад,Град");
                        Console.WriteLine();
                        break;
                    case "Хорошая":
                        Console.WriteLine("{0} =  Good.", WeatherToday);
                        break;
                    case "Плохая":
                        Console.WriteLine("{0} =  Bad.", WeatherToday);
                        break;
                    case "Нормальная":
                        Console.WriteLine("{0} =  Normal.", WeatherToday);
                        break;
                    case "Солнечная":
                        Console.WriteLine("{0} =  Solar.", WeatherToday);
                        break;
                    case "Облачная":
                        Console.WriteLine("{0} =  Cloudy.", WeatherToday);
                        break;
                    case "Дождь":
                        Console.WriteLine("{0} =  Rain.", WeatherToday);
                        break;
                    case "Ливень":
                        Console.WriteLine("{0} =  Downpour.", WeatherToday);
                        break;
                    case "Гроза":
                        Console.WriteLine("{0} =  Storm.", WeatherToday);
                        break;
                    case "Снегопад":
                        Console.WriteLine("{0} =  Snowfall.", WeatherToday);
                        break;
                    case "Град":
                        Console.WriteLine("{0} =  Hailstones.", WeatherToday);
                        break;
                    default:
                        Console.WriteLine("Не правильныый ввод, пожалуйста, повторите попытку");
                        Console.WriteLine();
                        break;
                }
            }
            while (Ques());
        
        bool Ques()
        {
            Console.Write("Желаете продолжить?(Да/Нет) ");
            string choise = Console.ReadLine();
            if (choise == "Нет") return false;
            else
            {
                Console.WriteLine();
                return true;
            }
        }
    }
    }
}
