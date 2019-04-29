using CalculatorForTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _target;

        [TestInitialize]

        public void Init()
        {
            _target = new Calculator();
        }

        [TestMethod]
        public void SumTest()
        {
            var actual = _target.Sum(1.5, 2.3);
            Assert.AreEqual(3.8,actual);
        }
    }
}
