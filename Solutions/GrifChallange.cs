namespace Solutions
{
    public static class GridChallenge
    {
        public static void Test()
        {
            Console.WriteLine(gridChellenge(new List<string> { "abc", "ade", "efg" }));
            Console.WriteLine(gridChellenge(new List<string>{"ebacd", "fghij", "olmkn", "trpqs", "xywuv"}));
        }

        private static string gridChellenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                grid[i] = String.Concat(grid[i].OrderBy(c => c));
                if (i > 0)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] < grid[i - 1][j])
                        {
                            return "NO";
                        }
                    }
                }
            }
            return "YES";
        }
    }
}
