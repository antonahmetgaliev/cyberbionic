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
            var actual = _target.Sum(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            var actual = _target.Div(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            var actual = _target.Mul(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            var actual = _target.Sub(2, 5);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivErrorTest()
        {
            var actual = _target.Div(2, 0);
        }
    }
}
