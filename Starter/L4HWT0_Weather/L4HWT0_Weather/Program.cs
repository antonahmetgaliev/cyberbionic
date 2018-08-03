using System;

namespace L4HWT0_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Какая погода сегодня?(Введите '?' для подсказки)");
            string WeatherToday = Console.ReadLine();
            string choise;
            switch (WeatherToday)
            {
                case "?":
                    Console.WriteLine("(Хорошая,Плохая,Нормальная,Солнечная,Облачная,Дождь,Ливень,Гроза,Снегопад,Град");
                    goto Start;
                case "Хорошая":
                    Console.WriteLine("{0} =  Good.", WeatherToday);
                    if (ques())  goto Start; else break;                    
                case "Плохая":
                    Console.WriteLine("{0} =  Bad.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Нормальная":
                    Console.WriteLine("{0} =  Normal.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Солнечная":
                    Console.WriteLine("{0} =  Solar.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Облачная":
                    Console.WriteLine("{0} =  Cloudy.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Дождь":
                    Console.WriteLine("{0} =  Rain.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Ливень":
                    Console.WriteLine("{0} =  Downpour.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Гроза":
                    Console.WriteLine("{0} =  Storm.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Снегопад":
                    Console.WriteLine("{0} =  Snowfall.", WeatherToday);
                    if (ques()) goto Start; else break;
                case "Град":
                    Console.WriteLine("{0} =  Hailstones.", WeatherToday);
                    if (ques()) goto Start; else break;
                default:
                    Console.WriteLine("Не правильныый ввод, пожалуйста, повторите попытку");
                    Console.WriteLine();
                    goto Start;
            }
        
        bool ques()
        {
            Console.Write("Желаете продолжить?(Да/Нет) ");
            choise = Console.ReadLine();
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
