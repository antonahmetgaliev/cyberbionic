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
            Assert.IsNotNull(DelegateAverage.GetAverage(4));
        }
    }
}
