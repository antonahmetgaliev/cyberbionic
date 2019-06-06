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
        public void AddTest()
        {
            _target.Add(1, "1");
            Assert.AreEqual("1 - 1", _target[0]);
        }
    }
}
