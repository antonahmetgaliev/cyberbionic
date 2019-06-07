namespace L10HWT2MyList
{
    public static class ExtendedArray<T>
    {
        public static T[] GetArray(MyList<T> list)
        {
            var tempArray = new T[list.Count];
            for (var i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = (T) list[i];
            }

            return tempArray;
        }
    }
}