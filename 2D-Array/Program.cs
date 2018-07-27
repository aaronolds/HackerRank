using System;
using System.IO;

namespace _2D_Array
{
    class Program
    {
        /*
         * Complete the array2D function below.
         */
        static int array2D(int[][] arr)
        {
            int max = -999999;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int top = arr[i][x] + arr[i][x + 1] + arr[i][x + 2];
                    // System.Console.WriteLine(top);
                    int middle = arr[i + 1][x + 1];
                    // System.Console.WriteLine(middle);
                    int bottom = arr[i + 2][x] + arr[i + 2][x + 1] + arr[i + 2][x + 2];
                    // System.Console.WriteLine(bottom);

                    System.Console.WriteLine(top + middle + bottom);
                    max = Math.Max(max, (top + middle + bottom));
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];
            string[] inArray = new[] { "-1 -1 0 -9 -2 -2", "-2 -1 -6 -8 -2 -5", "-1 -1 -1 -2 -3 -4", "-1 -9 -2 -4 -4 -5", "-7 -3 -3 -2 -9 -9", "-1 -3 -1 -2 -4 -5" };

            for (int arrRowItr = 0; arrRowItr < 6; arrRowItr++)
            {
                arr[arrRowItr] = Array.ConvertAll(inArray[arrRowItr].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = array2D(arr);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
