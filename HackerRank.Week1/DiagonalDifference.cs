namespace HackerRank.Week1
{
    public static class DiagonalDifference
    {

        public static int diagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[i][ arr.Count - 1 - i];
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }
    }
}
