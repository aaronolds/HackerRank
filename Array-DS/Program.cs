using System;
using System.IO;
using System.Linq;

namespace Array_DS
{
    class Program
    {
        /*
         * Complete the reverseArray function below.
         */
        static int[] reverseArray(int[] a)
        {
            var list = a.ToList();
            list.Reverse();
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] res = reverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
