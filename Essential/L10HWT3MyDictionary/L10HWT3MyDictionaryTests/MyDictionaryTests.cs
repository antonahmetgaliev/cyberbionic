using L10HWT3MyDictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L10HWT3MyDictionaryTests
{
    [TestClass]
    public class MyDictionaryTests
    {
        private MyDictionary<int, string> _target;

        [TestInitialize]
        public void Init()
        {
            _target = new MyDictionary<int, string>();
        }

        [TestMethod]
        public void AddOneItemTest()
        {
            _target.Add(1, "1");
            Assert.AreEqual("1 - 1", _target[0]);
        }

        [TestMethod]
        public void AddThreeItemTest()
        {
            _target.Add(1, "1");
            _target.Add(2, "2");
            _target.Add(3, "3");
            Assert.AreEqual("1 - 1", _target[0]);
            Assert.AreEqual("2 - 2", _target[1]);
            Assert.AreEqual("3 - 3", _target[2]);
        }

        [TestMethod]
        public void CountTest()
        {
            _target.Add(1, "1");
            _target.Add(2, "2");
            _target.Add(3, "3");
            Assert.AreEqual(3, _target.Count());
        }
    }
}
