using System;
using System.Collections.Generic;

namespace L9HWT3DelegateAverage
{
    public static class DelegateAverage
    {
        public delegate int DelegateForList(int a);
        public delegate double AverageDelegate(List<DelegateForList> delegateForLists);

        public static double GetAverage(int countOfDelegate)
        {
            var delegateForList = new List<DelegateForList>(countOfDelegate);
            DelegateForList averageDelegate = i => i;
            for (var i = 0; i < delegateForList.Count; i++)
            {
                delegateForList[i] = averageDelegate;
            }
            AverageDelegate averageForDelegate = delegate (List<DelegateForList> intOfDelegates)
            {
                var sum = 0.0;
                var random = new Random();
                for (var i = 0; i < intOfDelegates.Count; i++)
                {
                    sum = intOfDelegates[i].Invoke(random.Next(10));
                }
                return sum;
            };
            return averageForDelegate(delegateForList);
        }
    }
}