using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp;

namespace UserAppTest
{
    [TestClass]
    public class UserTests
    {
        private User _target;

        [TestInitialize]
        public void Init()
        {
            _target = new User
            {
                Age = 33,
                Name = "Vasya"
            };
        }

        [TestMethod]
        public void SetAgeTest()
        {
            Assert.AreEqual(32, _target.Age);
        }

        [TestMethod]
        public void SetNameTest()
        {
            Assert.AreEqual("Vasya", _target.Name);
        }

        [TestMethod]
        public void SetSNameTest()
        {
            Assert.AreEqual("", _target.SName);
        }

        [TestMethod]
        public void SumTest()
        {
            var actual = _target.Sum(2.2, 3.3);
            Assert.AreEqual(5.5, actual);
        }

        [TestMethod]
        public void SumZeroTest()
        {
            var actual = _target.Sum(0, 0);
            Assert.AreEqual(5.5, actual);
        }
    }
}
