using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Program
    {
        /*
        * Complete the birthdayCakeCandles function below.
        */
        static int birthdayCakeCandles(int n, int[] ar)
        {
            var test = ar.ToList().OrderByDescending(x => x).ToList();
            var maxNum = test[0];
            return test.Count(x => x.Equals(maxNum));

        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1) return;
            
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(n, ar);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}