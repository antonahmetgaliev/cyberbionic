using System.Collections.Generic;
using L9HWT3DelegateAverage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L9HWT3AverageTests
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void GetAverageTest()
        {
            var actual = DelegateAverage.GetAverage(new List<int>(){2,4});
            Assert.AreEqual(3, actual);
        }
    }
}
