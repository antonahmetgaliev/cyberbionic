using System;

namespace L10HWT2MyList
{
    public class MyList<T>
    {
        private T[] _items;
        private T[] _tempArray;

        public MyList()
        {
            _items = new T[0];
        }

        public MyList(int capacity)
        {
            _items = new T[capacity];
        }

        private void CopyToTempArray()
        {
            _tempArray = new T[_items.Length + 1];
            for (var i = 0; i < _items.Length; i++)
            {
                _tempArray[i] = _items[i];
            }
        }

        private void CopyItemsToMainArray()
        {
            _items = new T[_tempArray.Length];
            _items = _tempArray;
        }

        public void Add(T item)
        {
            CopyToTempArray();
            _tempArray[_tempArray.Length-1] = item;
            CopyItemsToMainArray();
        }

        public object this[int i] => _items[i];

        public int Count => _items.Length;
    }
}