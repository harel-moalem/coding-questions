namespace Solutions
{
    public static class CaesarCipher
    {
        public static void Test()
        {
            Console.WriteLine(caesarCipher("dfsdfvccxbn", 4));
        }

        private static string caesarCipher(string s, int k)
        {
            char[] encrypted = new char[s.Length];
            int totalAB = 'z' - 'a' + 1;
            k = k % totalAB;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(c + k);
                    if (c > 'z')
                    {
                        c = (char)(c - totalAB);
                    }
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + k);
                    if (c > 'Z')
                    {
                        c = (char)(c - totalAB);
                    }
                }
                encrypted[i] = c;
            }

            return new string(encrypted);
        }
    }
}
