using System;
using L9HWT2DelegateCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L9HWT2DelegateCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SumTest()
        {
            var actual = Calculator.Sum(1, 2);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            var actual = Calculator.Sub(2, 1);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            var actual = Calculator.Mul(3, 2);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivByZeroExceptionTest()
        {
            var actual = Calculator.Div(2, 0);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            var actual = Calculator.Div(4, 2);
            Assert.AreEqual(2, actual);
        }
    }
}
