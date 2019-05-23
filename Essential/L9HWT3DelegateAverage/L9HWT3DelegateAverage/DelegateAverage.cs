using System;
using System.Collections.Generic;

namespace L9HWT3DelegateAverage
{
    public static class DelegateAverage
    {
        public delegate int DelegateForList();
        public delegate double AverageDelegate(List<DelegateForList> delegateForLists);

        public static double GetAverage(int countOfDelegate)
        {
            var delegateForList = new List<DelegateForList>();
            var random = new Random();
            DelegateForList averageDelegate = () => random.Next(100);
            for (var i = 0; i < countOfDelegate; i++)
            {
                delegateForList.Add(averageDelegate);
            }

            AverageDelegate averageForDelegate = delegate (List<DelegateForList> intOfDelegates)
            {
                var sum = 0.0;
                foreach (var t in intOfDelegates)
                {
                    sum += t.Invoke();
                }
                return sum/intOfDelegates.Count;
            };

            return averageForDelegate(delegateForList);
        }
    }
}