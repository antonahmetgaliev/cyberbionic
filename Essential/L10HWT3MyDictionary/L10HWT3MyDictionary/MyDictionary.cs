﻿using System;
using System.Collections.Generic;

namespace L10HWT3MyDictionary
{
    public class MyDictionary<TKey, TValue>
    {
        private readonly List<TKey> _key;
        private readonly List<TValue> _value;

        public MyDictionary()
        {
            _key = new List<TKey>();
            _value = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _key.Add(key);
            _value.Add(value);
        }

        public string this[int i] => PropValue(i);

        private string PropValue(int i)
        {
            return Convert.ToString(_key[i] + " - " + _value[i]);
        }

        public int Count()
        {
            return _key.Count;
        }
    }
}