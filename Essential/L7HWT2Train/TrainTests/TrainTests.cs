using L7HWT2Train;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L7HWT2TrainTests
{

    [TestClass]
    public class TrainTests
    {
        private Train[] _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Train[8];
            for (var i = 0; i < _target.Length; i++)
            {
                var j = i + 1;
                _target[i]= new Train($"Destination {j}", j, $"0{j}:00");
            }
        }

        [TestMethod]
        public void DestinationTest()
        {
            Assert.AreEqual("Destination 1", _target[0].Destination);
        }

        [TestMethod]
        public void TrainNumberTest()
        {
            Assert.AreEqual(1, _target[0].TrainNumber);
        }

        [TestMethod]
        public void DepartureTimeTest()
        {
            Assert.AreEqual("01:00", _target[0].DepartureTime);
        }

    }
}
