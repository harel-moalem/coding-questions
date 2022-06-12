namespace Solutions
{
    public static class IsSmartNumber
    {
        public static void Test()
        {
            var arr = new int[] { 1, 2, 7, 169 };
            foreach(var a in arr){
                Console.WriteLine($"number {a} is {(!isSmartNumber(a) ? "not " :"")}a smart number");
            }
        }

        private static bool isSmartNumber(int number)
        {
            var val = Convert.ToInt32(Math.Sqrt(number));
            return Math.Sqrt(number) / val == 1;
        }
    }
}
