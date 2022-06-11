namespace Solutions
{
    public static class PickingNumbers
    {
        public static void Test() { }

        private static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int maxSubArrayCount = 0;
            int startIndex = 0;
            int endIndex = 0;
            int absDifferent = 0;
            for (int i = 1; i < a.Count; i++)
            {
                absDifferent += a[i] - a[i - 1];
                if (absDifferent <= 1)
                {
                    endIndex = i;
                }
                if (absDifferent > 1 || i == a.Count - 1)
                {
                    absDifferent = 0;
                    maxSubArrayCount = Math.Max(endIndex - startIndex + 1, maxSubArrayCount);
                    startIndex = i;
                }
            }
            return maxSubArrayCount;
        }
    }
}
