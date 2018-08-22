namespace L2HWT3EmployeeV2
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private string _position;
        private int _experience;
        private double _salary;

        public  Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void AddInfo(string position, int experience)
        {
            _position = position;
            _experience = experience;
            var salary = new Salary();
            _salary = salary.GetSalary(position, experience);
        }

        public string ShowName()
        {
            return _name;
        }

        public string ShowSurname()
        {
            return _surname;
        }

        public string ShowPositon()
        {
            return _position;
        }

        public int ShowExperience()
        {
            return _experience;
        }

        public double ShowSalary()
        {
            return _salary;
        }
    }
}
