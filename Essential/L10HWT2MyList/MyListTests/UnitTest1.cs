using L10HWT2MyList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTests
{
    [TestClass]
    public class UnitTest1
    {
        private MyList<int> _target;

        [TestInitialize]
        public void Init()
        {
            _target = new MyList<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            _target.Add(2);
            
        }
    }
}
