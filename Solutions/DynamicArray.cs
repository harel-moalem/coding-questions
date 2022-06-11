namespace Solutions
{
    public static class DynamicArray
    {
        public static void Test()
        {
            Console.WriteLine(
                string.Join(
                    ", ",
                    dynamicArray(
                        2,
                        new List<List<int>>
                        {
                            new List<int> { 1, 0, 5 },
                            new List<int> { 1, 1, 7 },
                            new List<int> { 1, 0, 3 },
                            new List<int> { 2, 1, 0 },
                            new List<int> { 2, 1, 1 }
                        }
                    )
                )
            );
        }

        private static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var arr = new List<int>[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new List<int>();
            }
            var answers = new List<int>();
            int lastAnswer = 0;
            foreach (var query in queries)
            {
                var x = query[1];
                var y = query[2];
                var idx = (x ^ lastAnswer) % n;
                if (query[0] == 1)
                {
                    arr[idx].Add(y);
                }
                else
                {
                    lastAnswer = arr[idx][y % arr[idx].Count];
                    answers.Add(lastAnswer);
                }
            }
            return answers;
        }
    }
}
