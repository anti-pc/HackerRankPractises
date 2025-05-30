using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Week1
{

    internal class FlippingMatrix
    {

        /*
         * Complete the 'flippingMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
         */
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count / 2;
            int sum = 0;

            for (int i = 0; i < n; i++) // üst yarı satırlar
            {
                for (int j = 0; j < n; j++) // sol yarı sütunlar
                {
                    // 4 olasılık (flip ile gelebilecek değerler)
                    int a = matrix[i][j];
                    int b = matrix[i][2 * n - 1 - j];
                    int c = matrix[2 * n - 1 - i][j];
                    int d = matrix[2 * n - 1 - i][2 * n - 1 - j];

                    // En büyük olanı seç
                    int maxVal = Math.Max(Math.Max(a, b), Math.Max(c, d));

                    // Toplama ekle
                    sum += maxVal;
                }
            }

            return sum;
        }

        public static void Result(List<List<int>> matrix)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int q = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<List<int>> matrix = new List<List<int>>();

            //    for (int i = 0; i < 2 * n; i++)
            //    {
            //        matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            //    }

            int result = FlippingMatrix.flippingMatrix(matrix);

            Console.WriteLine(result);
            //}

        }
    }
}
