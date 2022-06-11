namespace Solutions
{
    public static class MajorityElement
    {
        public static void Test()
        {
            Console.WriteLine(majorityElement(new List<int> { 1, 2, 3, 4 }));
        }

        private static int majorityElement(List<int> A)
        {
            int appearancesToBeMajority = A.Count / 2;
            A.Sort();
            int[] lastElementAppearanceCount = new int[2];
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0 || A[i] != lastElementAppearanceCount[0])
                {
                    lastElementAppearanceCount[0] = A[i];
                    lastElementAppearanceCount[1] = 1;
                }
                else
                {
                    lastElementAppearanceCount[1]++;
                }
                if (lastElementAppearanceCount[1] > appearancesToBeMajority)
                {
                    break;
                }
            }

            return lastElementAppearanceCount[1];
        }
    }
}
