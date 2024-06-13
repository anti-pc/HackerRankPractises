﻿namespace HackerRank.Week1
{
    public static class PermutingTwoArrays
    {
        /* 
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY A
         *  3. INTEGER_ARRAY B
         */
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort((a, b) => b.CompareTo(a)); //descending sort


            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                    return "NO";
            }

            return "YES";
        }
    }
}
