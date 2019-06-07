using L10HWT2MyList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTests
{
    [TestClass]
    public class MyListTests
    {
        private MyList<int> _target;

        [TestInitialize]
        public void Init()
        {
            _target = new MyList<int>();
        }

        [TestMethod]
        public void AddOneItemsTest()
        {
            _target.Add(2);
            Assert.AreEqual(2, _target[0]);
        }

        [TestMethod]
        public void AddThreeItemsTest()
        {
            _target.Add(1);
            _target.Add(2);
            _target.Add(3);
            Assert.AreEqual(1, _target[0]);
            Assert.AreEqual(2, _target[1]);
            Assert.AreEqual(3, _target[2]);
        }

        [TestMethod]
        public void CountTest()
        {
            _target.Add(1);
            _target.Add(2);
            _target.Add(3);
            Assert.AreEqual(3, _target.Count);
        }
    }
}
