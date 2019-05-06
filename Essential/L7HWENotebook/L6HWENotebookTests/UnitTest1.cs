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
        public void ModelTest()
        {
            Assert.AreEqual("80 qq", _target.Model);
        }

        [TestMethod]
        public void ManufacturerTest()
        {
            Assert.AreEqual("Lenovo", _target.Manufacturer);
        }

        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(5000, _target.Price);
        }
    }
}
