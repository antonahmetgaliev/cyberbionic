using System.Collections.Generic;
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
        public void SetNotesTest()
        {
            _target.SetNotes("1 comment",1);
            var actual = _target.Show();
            var expectationList = new List<string>
            {
                "1 page Comment: 1 comment", "2 page Comment: ", "3 page Comment: "
            };
            CollectionAssert.AreEqual(expectationList, actual);
        }

        [TestMethod]
        public void ChangeNotesTest()
        {
            _target.ChangeNotes("changed note",1);
            var actual = _target.Show();
            var expectationList = new List<string>
            {
                "1 page Comment: changed note", "2 page Comment: ", "3 page Comment: "
            };
            CollectionAssert.AreEqual(expectationList, actual);
        }

        [TestMethod]
        public void DeleteNotesTest()
        {
            _target.DeleteNotes(1);
            var actual = _target.Show();
            var expectationList = new List<string>
            {
                "1 page Comment: ", "2 page Comment: ", "3 page Comment: "
            };
            CollectionAssert.AreEqual(expectationList, actual);
        }
    }
}
