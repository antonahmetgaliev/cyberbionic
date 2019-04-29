﻿using System;
using System.Collections.Generic;

namespace L6HWT3Book
{
    public class Book
    {
        private static List<string> _book;
        private readonly Notes _notes = new Notes(); 

        public Book(List<string> book)
        {
            _book = book;
        }

        public class Notes
        {
            private readonly List<string> _notes = new List<string>();

            public bool SetNotes(string comment, int page)
            {
                if (_book.Count < page)
                {
                    _notes[page] = comment;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool DeleteNotes(int page)
            {
                return _notes.Remove(_notes[page]);
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
    }
}