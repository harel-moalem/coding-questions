namespace Solutions
{
    public static class GetTotalX
    {
        public static void Test() { }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;
            for (int i = a.Max(); i < b.Min(); i++)
            {
                if (a.All(num => i % num == 0) && b.All(num => num % i == 0))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
