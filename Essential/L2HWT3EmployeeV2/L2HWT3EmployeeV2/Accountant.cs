using System.Collections.Generic;

namespace L2HWT3EmployeeV2
{
    public class Accountant
    {
        private readonly List<Employee> _employees;
        private readonly Salary _salary;

        public Accountant(List<Employee> employees, Salary salary)
        {
            _employees = employees;
            _salary = salary;
        }

        public void CalculSalary()
        { 
            foreach (var t in _employees)
            {
                t.RefreshSalary(_salary.GetSalary(t.Position(), t.Experience()));
            }
        }

        public void ChangeOwnerConst(double perc)
        {
            _salary.ChangeOwnerConst(perc);
            CalculSalary();
        }

        public void ChangeAccountantConst(double perc)
        {
            _salary.ChangeAccConst(perc);
            CalculSalary();
        }

        public void ChangeWorkerConst(double perc)
        {
            _salary.ChangeWorkerConst(perc);
            CalculSalary();
        }

        public void AddNewEmployee(Employee listEmployee)
        {
            _employees.Add(listEmployee);
        }

        public List<List<string>> CheckedAcces(string position)
        {
            switch (position)
            {
                case "Owner":
                    return OwnerInfo();
                case "Accountant":
                    return AccInfo();
                default: return WorkerInfo();
            }
        }

        private List<List<string>> OwnerInfo()
        {
            var info = new List<List<string>>();
            for (var i = 0; i < _employees.Count; i++)
            {
                info[i] = _employees[i].ShowInfo();
            }
            return info;
        }

        private List<List<string>> AccInfo()
        {
            var info = new List<List<string>>();
            for (int i = 0, j = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Position() == "Owner") continue;
                info[j] = _employees[i].ShowInfo();
                ++j;
            }
            return info;
        }

        private List<List<string>> WorkerInfo()
        {
            var info = new List<List<string>>();
            for (int i = 0, j = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Position() != "Worker") continue;
                info[j] = _employees[i].ShowInfo();
                ++j;
            }
            return info;
        }
    }
}
