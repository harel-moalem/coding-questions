namespace Solutions
{
    public static class CountSort
    {
        public static void Test()
        {
            // countSort(
            //     new List<List<string>>
            //     {
            //         new List<string> { "0", "a" },
            //         new List<string> { "1", "b" },
            //         new List<string> { "0", "c" },
            //         new List<string> { "1", "d" }
            //     }
            // );

            countSort(
                new List<List<string>>
                {
                    new List<string> { "0", "ab" },
                    new List<string> { "6", "cd" },
                    new List<string> { "0", "ef" },
                    new List<string> { "6", "gh" },
                    new List<string> { "4", "ij" },
                    new List<string> { "0", "ab" },
                    new List<string> { "6", "cd" },
                    new List<string> { "0", "ef" },
                    new List<string> { "6", "gh" },
                    new List<string> { "0", "ij" },
                    new List<string> { "4", "that" },
                    new List<string> { "3", "be" },
                    new List<string> { "0", "to" },
                    new List<string> { "1", "be" },
                    new List<string> { "5", "question" },
                    new List<string> { "1", "or" },
                    new List<string> { "2", "not" },
                    new List<string> { "4", "is" },
                    new List<string> { "2", "to" },
                    new List<string> { "4", "the" }
                }
            );
            // countSort(
            //     new List<List<string>>
            //     {
            //         new List<string> { "1", "e" },
            //         new List<string> { "2", "a" },
            //         new List<string> { "1", "b" },
            //         new List<string> { "3", "a" },
            //         new List<string> { "4", "f" },
            //         new List<string> { "1", "f" },
            //         new List<string> { "2", "a" },
            //         new List<string> { "1", "e" },
            //         new List<string> { "1", "b" },
            //         new List<string> { "1", "c" }
            //     }
            // );
            // List<List<string>> test = null;

            // foreach (string line in System.IO.File.ReadLines(@"input05.txt"))
            // {
            //     if(test == null)
            //     {
            //         var count = int.Parse(line);
            //         test = new List<List<string>>(count);
            //     }else{
            //     test.Add(new List<string>(line.Split(' ')));
            //     }
            // }
            // countSort(test);
        }

        public static void countSort(List<List<string>> arr)
        {
            List<string>[] result = new List<string>[100];
            int maxIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                var item = arr[i];
                int index = int.Parse(item[0]);
                if (result[index] == null)
                {
                    result[index] = new List<string>();
                }
                maxIndex = Math.Max(maxIndex, index);
                string strToAdd = "";
                for (int j = 1; j < item.Count; j++)
                {
                    strToAdd += i < arr.Count / 2 ? "-" : item[j];
                }
                result[index].Add(strToAdd);
            }
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                
            for (int i = 0; i <= maxIndex; i++)
            {
                if (result[i] == null)
                {
                    continue;
                }

                for (var j = 0; j < result[i].Count; j++)
                {
                    var str = result[i][j];

                    if (str.Contains("-"))
                    {
                        sb.Append(string.Join(" ", str));
                    }
                    else
                    {
                        sb.Append(str);
                    }
                    if (i < maxIndex || j < result[i].Count - 1)
                    {
                        sb.Append(" ");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
