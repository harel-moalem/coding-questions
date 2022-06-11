namespace Solutions
{
    public static class MatchingStrings
    {
        public static void Test()
        {
            //Console.WriteLine(matchingStrings)
        }

        private static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> results = new List<int>();

            foreach (var query in queries)
            {
                int count = 0;
                foreach (var s in strings)
                {
                    if (s.Contains(query))
                    {
                        count++;
                    }
                }
                results.Add(count);
            }
            return results;
        }
    }
}
