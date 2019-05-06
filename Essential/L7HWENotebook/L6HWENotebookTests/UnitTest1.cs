using L7HWENotebook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L6HWENotebookTests
{
    [TestClass]
    public class UnitTest1
    {
        private Notebook _target; 
        [TestInitialize]
        public void Init()
        {
            _target = new Notebook("80 qq","Lenovo", 5000);
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
