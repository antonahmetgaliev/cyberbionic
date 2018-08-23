using System.Collections.Generic;
using L2HWT3EmployeeV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2HWT3EmployeeV2Test
{
    [TestClass]
    public class AccountantTest
    {
        private Accountant _target;

        [TestInitialize]
        public void Init()
        {
            var salary = new Salary();
            var employees = new List<Employee>();
            _target = new Accountant(employees, salary);
        }

        [TestMethod]
        public void ChangeWorkerConstTest()
        {
            _target.ChangeWorkerConst(0.20);
        }
    }
    
}
