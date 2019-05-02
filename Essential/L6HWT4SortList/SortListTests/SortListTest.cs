using System.Collections.Generic;
using L6HWT4SortList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortListTests
{
    [TestClass]
    public class SortListTest
    {
        private SortList _target;
        [TestInitialize]
        public void Init()
        {
            _target = new SortList(new List<int> {23,34,53});
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
