namespace Solutions
{
    public static class Anagram
    {
        public static void Test()
        {
            Console.WriteLine(anagram("fdsfsdfsd"));
        }

        private static int anagram(string s)
        {
            int changes = -1;
            if (s.Length % 2 == 0)
            {
                int[] charCount = new int[30];
                for (int i = 0; i < s.Length; i++)
                {
                    int index = s[i] - 'a';
                    if (i < s.Length / 2)
                    {
                        charCount[index]++;
                    }
                    else
                    {
                        charCount[index] = Math.Max(0, charCount[index] - 1);
                    }
                }
                changes = charCount.Sum();
            }
            return changes;
        }
    }
}
