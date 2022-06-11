namespace Solutions
{
    public static class FlippingMatrix
    {
        public static void Test() { }

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int size = matrix.Count;
            for (int i = 0; i < size / 2; i++)
            {
                for (int j = 0; j < size / 2; j++)
                {
                    sum += new int[]
                    {
                        matrix[i][j],
                        matrix[i][size - 1 - j],
                        matrix[size - 1 - i][j],
                        matrix[size - 1 - i][size - 1 - j]
                    }.Max();
                }
            }
            return sum;
        }
    }
}
