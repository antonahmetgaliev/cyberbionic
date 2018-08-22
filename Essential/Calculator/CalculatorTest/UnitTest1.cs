using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        private Calc _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Calc();
        }

        [TestMethod]
        public void SumTest()
        {
            int actual = _target.Sum(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            double actual = _target.Div(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivErrorTest()
        {
            double actual = _target.Div(2, 0);
        }
    }
}
