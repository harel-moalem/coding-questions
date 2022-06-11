public static class CollatzConjecture{
    public static long solve(int A, int B)
    {
        long result = A;
        for(int i = 1; i < B; i++)
        {            
            if(result % 2 == 0)
            {
                result = result / 2;
            }else{
                result = 3 * result + 1;
            }            
        }
        return result;
    }
}