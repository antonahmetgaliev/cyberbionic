using System.Collections.Generic;
using System.Linq;

namespace L9HWT3DelegateAverage
{
    public static class DelegateAverage
    {
        public delegate int DelegateForList(int a);

        public delegate double AverageDelegate(List<int> delegateForLists);

        public static double GetAverage(List<int> listForDelegate)
        {
            var delegateForList = new List<int>();
            DelegateForList averageDelegate = i => i;
            foreach (var t in listForDelegate)
            {
                delegateForList.Add(averageDelegate(t));
            }
            AverageDelegate averageForDelegate = intOfDelegates => intOfDelegates.ToArray().Sum()/intOfDelegates.Count;
            return averageForDelegate(delegateForList);
            //var sumOfDelegate = delegateForList.ToArray().Sum();
            //averageDelegate = delegate(List<DelegateForList> delegateForLists)
            //{return delegateForLists.ToArray().Sum() / delegateForLists.Count;};
        }
    }
}