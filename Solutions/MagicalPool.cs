namespace Solutions
{
    public static class MagicalPool
    {
        public static void Test()
        {
            Console.WriteLine(
                magicalPool(
                    new List<List<int>>()
                    {
                        new List<int> { 4, 5, 1, 5 }
                    }
                )
            );
        }

        private static int magicalPool(List<List<int>> A)
        {
            //sort
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<List<int>> pq = new List<List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                map.TryAdd(A[i][0], A[i][1]);
                var p = new List<int>() { A[i][0], A[i][1] };
                int index = 0;

                while (
                    index < pq.Count
                    && ((pq[index][0] == p[0] && pq[index][1] > p[1]) || pq[index][0] > p[0])
                )
                {
                    index++;
                }
                pq.Insert(index, p);
            }
            int answer = 0;
            while (pq.Count > 1)
            {
                List<int> p = pq[0];
                pq.RemoveAt(0);
                if (map.ContainsKey(p[0]))
                {
                    answer += p[1];
                    map.Remove(p[0]);
                    int ql = p[0] / 2;
                    int qt = p[0] * 2;
                    map.TryAdd(ql, qt);
                    var newp = new List<int> { ql, qt };
                    int index = 0;
                    while (
                        index < pq.Count
                        && (
                            (pq[index][0] == newp[0] && pq[index][1] > newp[1])
                            || pq[index][0] > newp[0]
                        )
                    )
                    {
                        index++;
                    }
                    pq.Insert(index, newp);
                }
            }
            return answer % ((int)1e9 + 7);
        }
    }
}
