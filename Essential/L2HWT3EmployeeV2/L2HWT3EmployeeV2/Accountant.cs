using System.Collections.Generic;

namespace L2HWT3EmployeeV2
{
    public class Accountant
    {
        private List<Employee> _employees;
        private readonly Salary _salary;

        public Accountant(List<Employee> employees, Salary salary)
        {
            _employees = employees;
            _salary = salary;
        }

        public void ChangeWorkerConst(double perc)
        {
            _salary.ChangeWorkerConst(perc);
        }
    }
}
