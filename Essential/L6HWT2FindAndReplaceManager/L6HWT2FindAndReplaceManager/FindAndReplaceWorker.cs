namespace L6HWT2FindAndReplaceManager
{
    internal static class FARWorker //FindAndReplaceWorker
    {
        public static string _allStr { get; set; }

        public static void AddStr(string allStr)
        {
            _allStr = allStr;
        }

        public static bool FindNext(string str)
        {
            return _allStr.Contains(str);
        }

        public static bool ReplaceNext(string findStr, string replStr)
        {
            var rez = _allStr.Contains(findStr);
            if (rez) _allStr = _allStr.Replace(findStr, replStr);
            return rez;
        }
    }
}
