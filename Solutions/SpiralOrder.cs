namespace Solutions
{
    public static class SpiralOrder
    {
        public static void Test()
        {
            Console.WriteLine(
                spiralOrder(
                    new List<List<int>>()
                    {
                        new List<int> { 1, 65, 3, 5, 6 }
                    }
                )
            );
        }

        private static List<int> spiralOrder(List<List<int>> A)
        {
            int top = 0;
            int bottom = A.Count - 1;
            int left = 0;
            int right = A[0].Count - 1;
            int dir = 0;
            List<int> result = new List<int>();
            while (top <= bottom && left <= right)
            {
                if (dir == 0) // l > r
                {
                    for (int i = left; i <= right; i++)
                    {
                        result.Add(A[top][i]);
                    }
                    top++;
                }
                else if (dir == 1) // t > b
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        result.Add(A[i][right]);
                    }
                    right--;
                }
                else if (dir == 2) // r > l
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(A[bottom][i]);
                    }
                    bottom--;
                }
                else if (dir == 3) // b > t
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(A[i][left]);
                    }
                    left++;
                }
                dir = (dir + 1) % 4;
            }

            return result;
        }
    }
}
