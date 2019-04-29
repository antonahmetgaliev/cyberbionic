using System.Collections.Generic;
using System.Linq;

namespace L6HWT3Book
{
    public class Book
    {
        private static List<string> _book;
        private readonly Notes _notes; 

        public Book(List<string> book)
        {
            _book = book;
            _notes = new Notes(_book.Count);
        }

        public class Notes
        {
            private readonly string[]_notes;

            public Notes(int count)
            {
                _notes = new string[count];
            }

            public bool SetNotes(string comment, int page)
            {
                if (_book.Count < page) return false;
                _notes[page-1] = comment;
                return true;
            }

            public bool DeleteNotes(int page)
            {
                if (_book.Count < page) return false;
                _notes[page-1]="";
                return true;
            }

            public string ShowNotes(int page)
            {
                return _notes[page];
            }
        }

        public bool SetNotes(string comment, int page)
        {
            return _notes.SetNotes(comment,page);
        }

        public bool DeleteNotes(int page)
        {
            return _notes.DeleteNotes(page);
        }

        public bool ChangeNotes(string newComment, int page)
        {
            return SetNotes(newComment, page);
        }

        public List<string> Show()
        {
            return _book.Select((t, i) => t + " Comment: " + _notes.ShowNotes(i)).ToList();
        }
    }
}