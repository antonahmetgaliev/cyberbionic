using System;

namespace L2HWT3Employee
{
    class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private string _position;
        private double _experience;
        private const double tax = 0.18;
        private const double salary = 1000;

        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public double Salary(string position, double experience)
        {
            _experience = experience;
            switch (_position = position)
            {
                case "accountant":
                    return SalaryCalcul(salary * 1.5, _experience);
                case "security":
                    return SalaryCalcul(salary * 0.75, _experience);
                default:
                    return SalaryCalcul(salary * 2.5, _experience);
            }
        }

        private double SalaryCalcul(double salary, double experience)
        {
            if (experience >= 5)
                if (experience >= 10)
                    if (experience >= 15)
                        if (experience >= 20)
                            if (experience >= 25)
                            return salary + salary * 0.5; 
                            else
                            return salary + salary * 0.45;
                        else
                        return salary + salary * 0.35; 
                    else
                    return salary + salary * 0.25;  
                else
                return salary + salary * 0.15; 
             return salary + salary * 0.1;
        }

        public void Show(double salary)
        {
            Console.WriteLine("\nName : {0} \nSurname : {1} \nPosition : {2} \nExperience : {3} \nSalary : {4} USD \nTax charge : {5} USD", _name, _surname, _position, _experience, salary, salary*tax);
        }
    }
}
