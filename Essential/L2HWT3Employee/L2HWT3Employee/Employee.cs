namespace L2HWT3Employee
{
    class Employee
    {
        private Workers[] workers;
        private const double tax = 0.18;
        private double salary = 1000;
        private double dirPer = 2.5;
        private double accPer = 1.5;
        private double empPer = 0.75;
        private int counter = 0;

        public Employee()
        {
            workers = new Workers[10];
        }

        public double Salary()
        {
            return salary;
        }
        public void Salary(double salary)
        {
            this.salary = salary;
        }

        public double DirPer()
        {
            return dirPer;
        }
        public void DirPer(double perc)
        {
            dirPer=perc;
        }

        public double AccPer()
        {
            return accPer;
        }
        public void AccPer(double perc)
        {
            accPer=perc;
        }

        public double EmpPer()
        {
            return empPer;
        }
        public void EmpPer(double perc)
        {
            empPer=perc;
        }

        public bool NewWorker(string name, string surname, string position, double experience)
        {
            if (counter != 10)
            {
                workers[counter] = new Workers(name, surname, position, experience, Salary(position, experience));
                counter++;
                return true;
            }
            return false;
        }

        private double Salary(string position, double experience)
        {
            switch (position)
            {
                case "accountant":
                    return SalaryCalcul(salary * accPer, experience);
                case "employee":
                    return SalaryCalcul(salary * empPer, experience);
                default:
                    return SalaryCalcul(salary * dirPer, experience);
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

        public double ShowSalary(int counter)
        {
            var salary= workers[counter].Salary();
            return salary - salary * tax;
        }

        public double ShowTax(int counter)
        {
            var salary = workers[counter].Salary();
            return salary * tax;
        }

        public string ShowName(int counter)
        {
            return workers[counter].Name();
        }

        public string ShowSurname(int counter)
        {
            return workers[counter].Surname();
        }

        public string ShowPosition(int counter)
        {
            return workers[counter].Position();
        }

        public double ShowExperience(int counter)
        {
            return workers[counter].Experience();
        }
    }
}
