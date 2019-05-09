using L8HWT2PrintColor;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L8HWT2PrintColorTests
{
    [TestClass]
    public class PrintColorTests
    {
        [TestMethod]
        public void PrintTest()
        {
            PrintColor.Print("123", 2);
        }
    }
}
