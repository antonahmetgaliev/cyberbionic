namespace L2HWT3EmployeeV2
{
    public class Salary
    {
        private const double WageConstant = 2000;
        private const double Tax = 0.18;
        private static double _ownerConst = 1;
        private static double _accConst = 0.5;
        private static double _workerConst = 0.25;

        public double GetSalary(string position, double experience)
        {
            var surcharge = experience / 10;
            surcharge = Surcharge(position, surcharge);
            var salary = WageConstant + WageConstant * surcharge;
            salary -= salary * Tax;
            return salary;
        }

        private static double Surcharge(string position, double surcharge)
        {
            switch (position)
            {
                case "Owner":
                    surcharge += _ownerConst;
                    break;
                case "Accountant":
                    surcharge += _accConst;
                    break;
                default:
                    surcharge -= _workerConst;
                    break;
            }
            return surcharge;
        }

        public void ChangeOwnerConst(double perc)
        {
            _ownerConst = perc;
        }

        public void ChangeAccConst(double perc)
        {
            _accConst = perc;
        }

        public void ChangeWorkerConst(double perc)
        {
            _workerConst = perc;
        }
    }
}
