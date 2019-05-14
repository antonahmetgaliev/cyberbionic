namespace L9HWT2DelegateCalculator
{
    public static class Calculator
    {
        private delegate int DelegateCalculator(int a, int b);

        public static int Sum(int a, int b)
        {
            DelegateCalculator delegateSum = (i, i1) => a + b;
            return delegateSum(a, b);
        }
        public static int Sub(int a, int b)
        {
            DelegateCalculator delegateSub = (i, i1) => a - b;
            return delegateSub(a, b);
        }
        public static int Mul(int a, int b)
        {
            DelegateCalculator delegateMul = (i, i1) => a * b;
            return delegateMul(a, b);
        }
        public static int Div(int a, int b)
        {
            DelegateCalculator delegateDiv = (i, i1) => a / b;
            return delegateDiv(a, b);
        }
    }
}