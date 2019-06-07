namespace L10HWT2MyList
{
    public static class ExtendedArray<T>
    {
        private static T[] _tempArray;

        public static T[] GetArray(MyList<T> list)
        {
            _tempArray = new T[list.Count];
            for (var i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = (T) list[i];
            }
            return _tempArray;
        }
    }
}