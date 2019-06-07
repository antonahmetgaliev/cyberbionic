namespace L10HWT4MyListWithExtendedMethodV2
{
    public static class ExtendedArray
    {
        private static int[] _tempArray;

        public static int[] GetArray(this MyList<int> list)
        {
            _tempArray = new int[list.Count];
            for (var i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = (int)list[i];
            }
            return _tempArray;
        }
    }
}