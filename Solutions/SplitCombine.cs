namespace Solutions
{
    public static class SplitCombine
    {
        public static void Test()
        {
            splitCombine();
        }

        private static void splitCombine()
        {
            string[] lines = new string[]
            {
                "S;M;plasticCup()",
                "C;V;mobile phone",
                "C;C;coffee machine",
                "S;C;LargeSoftwareBook",
                "C;M;white sheet of paper",
                "S;V;pictureFrame"
            };
            foreach (var input in lines)
            {
                char operation = input[0];
                char nameType = input[2];
                string name = input.Substring(4);

                if (operation == 'S')
                {
                    if (nameType == 'M' && name.IndexOf('(') != -1)
                    {
                        name = name.Substring(0, name.IndexOf('('));
                    }
                    string words = "";
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (i != 0)
                        {
                            if (Char.IsUpper(name[i]))
                            {
                                words += " ";
                            }
                        }
                        words += Char.ToLower(name[i]);
                    }
                    Console.WriteLine(words);
                }
                else
                {
                    string[] allWords = name.Split(' ');
                    for (int i = 0; i < allWords.Length; i++)
                    {
                        if (i > 0 || nameType == 'C')
                        {
                            allWords[i] = Char.ToUpper(allWords[i][0]) + allWords[i].Substring(1);
                        }
                    }
                    Console.WriteLine(string.Join("", allWords) + (nameType == 'M' ? "()" : ""));
                }
            }
        }
    }
}
