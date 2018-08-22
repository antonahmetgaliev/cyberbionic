using L2HWT3EmployeeV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2HWT3EmployeeV2Test
{
    [TestClass]
    public class SalaryTest
    {
        private Salary _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Salary();
        }

        [TestMethod]
        public void GetSalaryTest()
        {
            var actual = _target.GetSalary("owner",25);
            Assert.AreEqual(actual,actual);
        }

        [TestMethod]
        public void ChangeOwnerConstTest()
        {
            _target.ChangeOwnerConst(1.1);
        }

        [TestMethod]
        public void ChangeAccConstTest()
        {
            _target.ChangeAccConst(0.6);
        }

        [TestMethod]
        public void ChangeWorkerConstTest()
        {
            _target.ChangeWorkerConst(0.2);
        }
    }
}