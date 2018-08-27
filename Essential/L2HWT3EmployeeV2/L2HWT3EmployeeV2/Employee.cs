using System;
using System.Collections.Generic;

namespace L2HWT3EmployeeV2
{
    public class Employee
    {
        private readonly Salary _calculSalary;
        private readonly string _name;
        private readonly string _surname;
        private string _position { get; set; }
        private int _experience { get; set; }
        private double _salary;

        public string Position()
        {
            return _position;
        }

        public double Experience()
        {
            return _experience;
        }

        public void ChangePosition(string position, double salary)
        {
            _position = position;
            _salary = salary;
        }

        public void RefreshSalary(double salary)
        {
            _salary = salary;
        }

        public  Employee(string name, string surname, string position, int experience, int salary)
        {
            _name = name;
            _surname = surname;
            _position = position;
            _experience = experience;
            _salary = salary;
        }

        public List<string> ShowInfo()
        {
            var employees = new List<string>
            {
                _name,
                _surname,
                _position,
                Convert.ToString(_experience),
                (Convert.ToString(_salary))
            };
            return employees;
        }

        public override string ToString()
        {
            return $"{nameof(_calculSalary)}: {_calculSalary}, {nameof(_name)}: {_name}, {nameof(_surname)}: {_surname}, {nameof(_salary)}: {_salary}, {nameof(_position)}: {_position}, {nameof(_experience)}: {_experience}";
        }
    }
}
