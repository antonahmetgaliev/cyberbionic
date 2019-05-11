using L8HWT3Premium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L8HWT3PremiumTests
{
    [TestClass]
    public class AccountantTests
    {
        [TestMethod]
        public void AskForBonus_Worker_IsNotBonus_Test()
        {
            Assert.IsFalse(Accountant.AskForBonus(Accountant.Post.Worker, 239));
        }

        [TestMethod]
        public void AskForBonus_Worker_IsBonus_Test()
        {
            Assert.IsTrue(Accountant.AskForBonus(Accountant.Post.Worker, 240));
        }

        [TestMethod]
        public void AskForBonus_Manager_IsNotBonus_Test()
        {
            Assert.IsFalse(Accountant.AskForBonus(Accountant.Post.Manager, 199));
        }

        [TestMethod]
        public void AskForBonus_Manager_IsBonus_Test()
        {
            Assert.IsTrue(Accountant.AskForBonus(Accountant.Post.Manager, 200));
        }

        [TestMethod]
        public void AskForBonus_Accountant_IsNotBonus_Test()
        {
            Assert.IsFalse(Accountant.AskForBonus(Accountant.Post.Accountant, 219));
        }

        [TestMethod]
        public void AskForBonus_Accountant_IsBonus_Test()
        {
            Assert.IsTrue(Accountant.AskForBonus(Accountant.Post.Accountant, 220));
        }
    }
}
