namespace Solutions
{
    public static class Birthday
    {
        public static void Test() { }

        private static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count; i += m)
            {
                if ((i + m) > s.Count)
                {
                    break;
                }
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += s[j + i];
                }
                if (sum == d)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
