using L2HWT3EmployeeV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2HWT3EmployeeV2Test
{
    [TestClass]
    public class EmployeeTest
    {
        private Employee _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Employee("Anton", "Ahmetgaliev", "Owner", 25);
        }
    }
}