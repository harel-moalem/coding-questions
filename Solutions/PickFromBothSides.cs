namespace Solutions
{
    public static class PickFromBothSides
    {
        public static void Test()
        {
            Console.WriteLine(pickFromBothSides(new List<int> { 4, 6, 32, 1 }, 5));
        }

        private static int pickFromBothSides(List<int> A, int B)
        {
            int maxValue = int.MinValue;
            for (int i = B; i >= 0; i--)
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += A[j];
                }
                for (int j = 0; j < B - i; j++)
                {
                    sum += A[A.Count - 1 - j];
                }
                maxValue = Math.Max(maxValue, sum);
                Console.Write(sum + " | ");
            }
            return maxValue;
        }
    }
}
