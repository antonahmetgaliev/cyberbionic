using System;
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

            private void CheckComment(string comment, int page)
            {
                if (string.IsNullOrEmpty(comment))
                {
                    throw new ArgumentNullException(nameof(comment));
                }

                if (_book.Count < page)
                {
                    throw new ArgumentOutOfRangeException(nameof(page));
                }
            }

            public void SetNotes(string comment, int page)
            {
                CheckComment(comment, page);
                _notes[page-1] = comment;
            }

            public void DeleteNotes(int page)
            {
                _notes[page-1]="";
            }

            public string ShowNotes(int page)
            {
                return _notes[page];
            }
        }

        public void SetNotes(string comment, int page)
        {
            _notes.SetNotes(comment,page);
        }

        public void DeleteNotes(int page)
        {
            _notes.DeleteNotes(page);
        }

        public void ChangeNotes(string newComment, int page)
        {
            SetNotes(newComment, page);
        }

        public List<string> Show()
        {
            return _book.Select((t, i) => t + " Comment: " + _notes.ShowNotes(i)).ToList();
        }
    }
}