using L8HWT3Premium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L8HWT3PremiumTests
{
    [TestClass]
    public class AccauntantTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Accauntant.AskForBonus(Accauntant.Post.worker, 200);
        }
    }
}
