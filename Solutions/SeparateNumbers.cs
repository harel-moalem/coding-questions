namespace Solutions
{
    public static class SeparateNumbers
    {
        public static void Test()
        {
            separateNumbers("fsdfsd545654");
        }

        private static void separateNumbers(string s)
        {
            long beautifulStringStartNumber = -1;
            for (int digits = 1; digits <= s.Length / 2; digits++)
            {
                List<long> seq = new List<long>();
                int currentDigitsIterator = digits;
                for (int i = 0; i < s.Length; i += currentDigitsIterator)
                {
                    if (
                        seq.Count > 0
                        && (seq.Last() + 1).ToString().Length > seq.Last().ToString().Length
                    )
                    {
                        currentDigitsIterator++;
                        //check we are inside the string
                    }
                    if (currentDigitsIterator + i > s.Length)
                    {
                        seq = new List<long>();
                        break;
                    }
                    long currentNumber = long.Parse(s.Substring(i, currentDigitsIterator));
                    if (seq.Count == 0)
                    {
                        seq.Add(currentNumber);
                    }
                    else if (
                        currentNumber.ToString().Length == currentDigitsIterator
                        && currentNumber - seq.Last() == 1
                    )
                    {
                        seq.Add(currentNumber);
                    }
                    else
                    {
                        seq = new List<long>();
                        break;
                    }
                }
                if (seq.Count > 1)
                {
                    beautifulStringStartNumber =
                        beautifulStringStartNumber == -1
                            ? seq[0]
                            : Math.Min(seq[0], beautifulStringStartNumber);
                }
            }
            if (beautifulStringStartNumber > -1)
            {
                Console.WriteLine("YES " + beautifulStringStartNumber);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
