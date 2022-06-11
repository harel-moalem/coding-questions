namespace Solutions
{
    public static class MaxMin
    {
        public static void Test()
        {
            Console.WriteLine(maxMin(4, new List<int> { 45, 1, 3, 6 }));
        }

        public static int maxMin(int k, List<int> arr)
        {
            int maxMaxMin = -1;
            if (arr.Count >= k)
            {
                arr.Sort();
                for (int i = 0; i <= arr.Count - k; i++)
                {
                    var arrTag = arr.Skip(i).Take(k);
                    int currentMaxMin = arrTag.ElementAt(k - 1) - arrTag.ElementAt(0);
                    if (maxMaxMin == -1)
                    {
                        maxMaxMin = currentMaxMin;
                    }
                    else
                    {
                        maxMaxMin = Math.Min(currentMaxMin, maxMaxMin);
                    }
                }
            }
            return maxMaxMin;
        }
    }
}
