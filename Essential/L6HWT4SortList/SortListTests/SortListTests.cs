using System.Collections.Generic;
using L6HWT4SortList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortListTests
{
    [TestClass]
    public class SortListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = new List<int> {34, 53, 23};
            actual.SortUpList();
            var expectationList = new List<int> { 23, 34, 53 };
            Assert.AreEqual(expectationList,actual);
        }
    }
}
