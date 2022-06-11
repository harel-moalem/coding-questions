public class GasStation
{
    public int canCompleteCircuit(List<int> A, List<int> B)
    {
        for (var i = 0; i < A.Count; i++)
        {
            int result = -1;
            int carTank = 0;
            for (var j = 0; j < B.Count; j++)
            {
                var fixedIndex = (j + i) % B.Count;
                carTank += A[fixedIndex] - B[fixedIndex];
                if (carTank < 0)
                {
                    break;
                }
                if (j == B.Count - 1)
                {
                    result = i;
                }
            }
            if (result > -1)
            {
                return result;
            }
        }
        return -1;
    }

    public int canCompleteCircuitSuggested(List<int> A, List<int> B)
    {

        long currentPetrol = 0;
        int start = -1;
        int j = 0;

        for (int i = 0; i < A.Count; i++)
            {
            currentPetrol += A[i];

            //Not Enough Fuel
            if (B[i] > currentPetrol)
                {
                currentPetrol = 0;
                start = -1;
            }
                else
            {
                start = start == -1 ? i : start;
                currentPetrol = currentPetrol - B[i];
            }
        }


        while (j < start)
            {
            currentPetrol += A[j];

            if (B[j] > currentPetrol)
                {
                break;
            }
                else
            {
                currentPetrol = currentPetrol - B[j];
                j++;
            }

        }

        if (j == start)
        {
            return start;
        }

        return -1;






    }

}