using System;
using System.Linq;

namespace L5HWT2Array
{
    internal class NumArray
    {
        private readonly int[] _key;

        public NumArray(int arrayDimension)
        {
            _key = new int[arrayDimension];
        }

        public void EnterElements()
        {
            var rand = new Random();
            for (var i = 0; i < _key.Length; i++)
            {
                _key[i] = rand.Next(-100, 100);
            }
        }

        public int MaxArr()
        {
            return _key.Max();
        }

        public int MinArr()
        {
            return _key.Min();
        }

        public int SummArr()
        {
            return _key.Sum();
        }

        public int this[int index]
        {
            get => _key[index];
            set => _key[index] = value;
        }
    }
}