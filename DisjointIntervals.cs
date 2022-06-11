public static class DisjoinInterval
{

    public static int solve(List<List<int>> A)
    {

        if (A.Count < 1)
            return A.Count;
        var rlist = A.Select(
           lst => lst.OrderBy(i => i).ToList()
       );
        var sortedList = rlist.OrderBy(lst => lst.First()).ToList();
        var stack = new Stack<int>();
        stack.Push(sortedList[0].Last());
        for (var index = 1; index < sortedList.Count; index++)
        {
            var items = sortedList[index];
            if (stack.Any())
            {
                var top = stack.Peek();
                if (top < items.First())
                {
                    stack.Push(items.Last());
                }
                else if (top >= items.Last())
                {
                    stack.Pop();
                    stack.Push(items.Last());
                }
            }
            else
            {
                stack.Push(items.Last());
            }


        }
        return stack.Count;
    }

    private static void quickSort(List<List<int>> arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }
    private static int partition(List<List<int>> arr, int low, int high)
    {
        List<int> pivot = arr[high];
        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            if ((arr[j][0].ToString("d9") + arr[j][1].ToString("d9")).CompareTo(pivot[0].ToString("d9") + pivot[1].ToString("d9")) < 0)
            {
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return i + 1;
    }

    private static void swap(List<List<int>> arr, int i, int j)
    {
        List<int> t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }
}