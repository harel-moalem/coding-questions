namespace Solutions
{
    public static class MaximumPerimeterTriangle
    {
        public static void Test()
        {
            Console.WriteLine(maximumPerimeterTriangle(new List<int> { 4, 67, 3, 1 }));
        }

        private static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            int[] maxPer = null;

            if (sticks.Count > 2)
            {
                sticks.Sort();
                for (int i = 0; i < sticks.Count; i++)
                {
                    for (int j = i + 1; j < sticks.Count; j++)
                    {
                        for (int k = j + 1; k < sticks.Count; k++)
                        {
                            if (isTriangle(sticks[i], sticks[j], sticks[k]))
                            {
                                var currentTriangle = new int[3]
                                {
                                    sticks[i],
                                    sticks[j],
                                    sticks[k]
                                };
                                if (maxPer == null)
                                {
                                    maxPer = new int[3];
                                }

                                long currentSum = currentTriangle.Select(c => (long)c).Sum();
                                long maxSum = maxPer.Select(c => (long)c).Sum();
                                bool update =
                                    currentSum > maxSum
                                    || (
                                        currentSum == maxSum && currentTriangle.Min() > maxPer.Min()
                                    );
                                if (update)
                                {
                                    maxPer = currentTriangle;
                                }
                            }
                        }
                    }
                }
            }

            if (maxPer == null)
            {
                return new List<int>() { -1 };
            }

            return maxPer.ToList();
        }

        private static bool isTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
