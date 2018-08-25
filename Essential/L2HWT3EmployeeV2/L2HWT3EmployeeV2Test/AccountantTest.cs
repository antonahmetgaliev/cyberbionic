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

        [TestMethod]
        public void AddNewEmployeeTest()
        {
            _target.AddNewEmployee("Anton", "Ahmetgaliev", "Owner", 25);
        }

        [TestMethod]
        public void CheckedAccesTest()
        {
            var check = _target.CheckedAcces("Owner");
            Assert.AreEqual(check, check);
            check = _target.CheckedAcces("Accountant");
            Assert.AreEqual(check, check);
            check = _target.CheckedAcces("Worker");
            Assert.AreEqual(check, check);
        }
    }
    
}
