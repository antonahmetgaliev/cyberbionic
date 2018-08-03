using System;

namespace L4HWT2_calculator
{
    class Program
    {        
        static void Main(string[] args)
        {
            do
            {
                int operand1 = 0, operand2 = 0;
                Console.Write("Введите операнд 1 - ");
                string operands = Console.ReadLine();
                operand1 = Convert.ToInt32(operands);
                Console.Write("Введите операнд 2 - ");
                operands = Console.ReadLine();
                operand2 = Convert.ToInt32(operands);
                Console.Write("Введите знак арифметического действия - ");
                string arf = Console.ReadLine();
                switch (arf)
                {
                    case "+":
                        {
                            Calcul(operand1,operand2,arf);
                            break;
                        }
                    case "-":
                        {
                            Calcul(operand1, operand2, arf);
                            break;
                        }
                    case "*":
                        {                            
                            Calcul(operand1, operand2, arf);
                            break;
                        }
                    case "/":
                        {
                            if (operand2 != 0) Calcul(operand1, operand2, arf);                            
                            else
                            {
                                Console.WriteLine("На 0 делить запрещено!\n");                                                           
                            }
                            break;
                        }
                    case "%":
                        {
                            if (operand2 != 0) Calcul(operand1, operand2, arf);                            
                            else
                            {
                                Console.WriteLine("На 0 делить запрещено!\n");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода, выберите другой арифметический знак\n");                            
                            break;
                        }
                }
            }
            while (Ques());
            bool Ques()
            {                
                Console.Write("Желаете продолжить?(Y/N) ");
                string choise = Console.ReadLine();
                if (choise == "N") return false;
                else return true;
            }
            void Calcul(int operand1, int operand2, string arifmat)
            {
                int rez=0;
                if (arifmat == "+")
                {
                    rez = operand1 + operand2;
                }
                else if (arifmat == "-")
                {
                    rez = operand1 - operand2;
                }
                else if (arifmat == "*")
                {
                    rez = operand1 * operand2;
                }
                else if (arifmat == "/")
                {
                    rez = operand1 / operand2;
                }
                else if (arifmat == "%")
                {
                    rez = operand1 % operand2;
                }
                Console.WriteLine("{0} {3} {1} = {2}", operand1, operand2, rez, arifmat);
            }
        }
    }
}
