﻿using System.Collections.Generic;
using L6HWT3Book;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTests
{
    [TestClass]
    public class BookTests
    {
        private Book _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Book( new List<string> {"1 page", "2 page", "3 page"});
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
