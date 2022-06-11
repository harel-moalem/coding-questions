namespace Solutions
{
    public static class ClosestNumbers
    {
        public static void Test()
        {
            Console.WriteLine(closestNumbers(new List<int> { 54, 6, 32, 4, 5 }));
        }

        private static List<int> closestNumbers(List<int> arr)
        {
            arr.Sort();
            int minDifference = int.MaxValue;
            List<int> items = new List<int>();
            bool isSuccessive = false;
            for (int i = 1; i < arr.Count; i++)
            {
                int currentDif = arr[i] - arr[i - 1];
                if (currentDif < minDifference)
                {
                    items = new List<int>() { arr[i - 1], arr[i] };
                    minDifference = currentDif;
                    isSuccessive = true;
                }
                else if (currentDif == minDifference)
                {
                    if (!isSuccessive)
                    {
                        items.Add(arr[i - 1]);
                    }
                    items.Add(arr[i]);
                }
                else
                {
                    isSuccessive = false;
                }
            }

            return items;
        }
    }
}
