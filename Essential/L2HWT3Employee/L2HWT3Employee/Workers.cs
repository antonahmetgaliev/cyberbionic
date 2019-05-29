namespace L2HWT3Employee
{
    internal class Workers
    {
        private readonly string _name;
        private readonly string _surname;
        private string _position;
        private double _experience;
        private double _salary;

        public Workers(string name, string surname, string position, double experience, double salary)
        {
            _name = name;
            _surname = surname;
            _position = position;
            _experience = experience;
            _salary = salary;
        }

        public string Name()
        {
            return _name;
        }
        public string Surname()
        {
            return _surname;
        }
        public string Position()
        {
            return _position;
        }
        public double Experience()
        {
            return _experience;
        }
        public double Salary()
        {
            return _salary;
        }
    }
}
