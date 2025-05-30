using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Week1
{

    internal class FindMedian
    {

        /*
         * Complete the 'findMedian' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */


        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            return arr[(arr.Count - 1) / 2];
        }

        public static void Result(List<int> arr)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = FindMedian.findMedian(arr);

            Console.WriteLine(result);

        }
    }
}
