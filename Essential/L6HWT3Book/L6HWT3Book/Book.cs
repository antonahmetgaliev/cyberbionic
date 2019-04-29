using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace L6HWT3Book
{
    public class Book
    {
        private static List<string> _book;
        private Notes _notes = new Notes(); 

        public Book(List<string> book)
        {
            _book = book;
        }

        public class Notes
        {
            private List<string> _notes = new List<string>();

            public bool SetNotes(string comment, int i)
            {
                if (_book.Count < i)
                {
                    _notes[i] = comment;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SetNotes(string comment, int i)
        {
            return _notes.SetNotes(comment,i);
        }
    }
}