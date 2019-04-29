﻿using System.Collections.Generic;
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
            private readonly List<string> _notes;

            public Notes(int count)
            {
                _notes = new List<string>(count);
                for (var i = 0; i < count; i++)
                {
                    _notes.Add("");
                }
            }

            public bool SetNotes(string comment, int page)
            {
                if (_book.Count < page) return false;
                _notes.Insert(page, comment);
                return true;
            }

            public bool DeleteNotes(int page)
            {
                return _notes.Remove(_notes[page]);
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

        public void Show()
        {
            var bookShow = _book.Select((t, i) => t + "Comment: " + _notes.ShowNotes(i)).ToList();
        }
    }
}