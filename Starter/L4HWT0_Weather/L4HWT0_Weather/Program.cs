using System;

namespace L4HWT0_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exx = false;
            while (exx != true)
            {
                Console.WriteLine("Какая погода сегодня?(Введите '?' для подсказки)");
                string WeatherToday = Console.ReadLine();                
                switch (WeatherToday)
                {
                    case "?":
                        Console.WriteLine("(Хорошая,Плохая,Нормальная,Солнечная,Облачная,Дождь,Ливень,Гроза,Снегопад,Град");
                        {exx = true; break;};
                    case "Хорошая":
                        Console.WriteLine("{0} =  Good.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Плохая":
                        Console.WriteLine("{0} =  Bad.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Нормальная":
                        Console.WriteLine("{0} =  Normal.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Солнечная":
                        Console.WriteLine("{0} =  Solar.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Облачная":
                        Console.WriteLine("{0} =  Cloudy.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Дождь":
                        Console.WriteLine("{0} =  Rain.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Ливень":
                        Console.WriteLine("{0} =  Downpour.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Гроза":
                        Console.WriteLine("{0} =  Storm.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Снегопад":
                        Console.WriteLine("{0} =  Snowfall.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    case "Град":
                        Console.WriteLine("{0} =  Hailstones.", WeatherToday);
                        if (Ques()) {exx = true; break;} else break;
                    default:
                        Console.WriteLine("Не правильныый ввод, пожалуйста, повторите попытку");
                        Console.WriteLine();
                        break;
                }
            }
        
        bool Ques()
        {
            Console.Write("Желаете продолжить?(Да/Нет) ");
            string choise = Console.ReadLine();
            if (choise == "Нет") return true;
            else
            {
                Console.WriteLine();
                return false;
            }
        }
    }
    }
}
