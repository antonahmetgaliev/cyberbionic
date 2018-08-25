using System;
using System.Collections.Generic;

namespace L2HWT3EmployeeV2
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        public readonly string Position;
        private readonly int _experience;
        private readonly double _salary;

        public  Employee(string name, string surname, string position, int experience)
        {
            _name = name;
            _surname = surname;
            Position = position;
            _experience = experience;
            var salary = new Salary();
            _salary = salary.GetSalary(position, experience);
        }

        public List<string> ShowInfo()
        {
            var employees = new List<string>
            {
                _name,
                _surname,
                Position,
                Convert.ToString(_experience),
                (Convert.ToString(_salary))
            };
            return employees;
        }
    }
}
