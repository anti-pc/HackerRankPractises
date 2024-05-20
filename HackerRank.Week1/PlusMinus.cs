namespace HackerRank.Week1
{
    public static class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            double numOfPositive = 0;
            double numOfNegative = 0;
            double numOfZero = 0;
            foreach (int item in arr)
            {
                if (item == 0)
                    numOfZero++;
                if (item > 0)
                    numOfPositive++;
                if (item < 0)
                    numOfNegative++;
            }

            Console.WriteLine(numOfPositive / arr.Count);
            Console.WriteLine(numOfNegative / arr.Count);
            Console.WriteLine(numOfZero / arr.Count);

        }
    }
}
