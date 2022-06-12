namespace Solutions
{
    public static class MissingNumbers
    {
        public static void Test()
        {
            Console.WriteLine(
                string.Join(
                    ",",
                    missingNumbers(
                        new List<int> { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 },
                        new List<int>
                        {
                            203,
                            204,
                            204,
                            205,
                            206,
                            207,
                            205,
                            208,
                            203,
                            206,
                            205,
                            206,
                            204
                        }
                    )
                )
            );
        }

        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            HashSet<int> missingNumbers = new HashSet<int>();
            arr.Sort();
            brr.Sort();

            int bIndex = 0;
            int aIndex = 0;
            while (aIndex < arr.Count && bIndex < brr.Count)
            {
                if(arr[aIndex] == brr[bIndex])
                {
                    aIndex++;
                    bIndex++;
                    continue;
                }
                missingNumbers.Add(Math.Min(arr[aIndex], brr[bIndex]));
                if(arr[aIndex] < brr[bIndex])
                {
                    aIndex++;
                }else{
                    bIndex++;
                }
            }

            for (int i = bIndex; i < brr.Count; i++)
            {
                missingNumbers.Add(brr[i]);
            }
            for (int i = aIndex; i < arr.Count; i++)
            {
                missingNumbers.Add(arr[i]);
            }

            return missingNumbers.ToList();
        }
    }
}
