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

        [TestMethod]
        public void SubTest()
        {
            var actual = _target.Sub(1.5, 2.3);
            Assert.AreEqual(-0.8,actual);
        }

        [TestMethod]
        public void MulTest()
        {
            var actual = _target.Mul(2.5, 2);
            Assert.AreEqual(5,actual);
        }

        [TestMethod]
        public void DivTest()
        {
            var actual = _target.Div(2.8, 1.4);
            Assert.AreEqual(2,actual);
        }
    }
}
