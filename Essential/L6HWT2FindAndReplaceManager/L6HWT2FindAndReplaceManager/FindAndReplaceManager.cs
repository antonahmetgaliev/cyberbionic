namespace L6HWT2FindAndReplaceManager
{
    internal static class FARManager //FindAndReplaceManager
    {
        public static void AddStr(string allStr)
        {
            FARWorker.AddStr(allStr);
        }

        public static bool FindNext(string str)
        {
            return FARWorker.FindNext(str);
        }

        public static bool ReplaceNext(string findStr, string replStr)
        {
            return FARWorker.ReplaceNext(findStr, replStr);
        }

        public static string Show()
        {
            return FARWorker._allStr;
        }
    }
}
