using System;
using System.Collections.Generic;

namespace Apple_and_Oranges
{
    class Program
    {
        /*
        * Complete the countApplesAndOranges function below.
        */
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var applesHitHouse = 0;
            var orangesHitHouse = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                var testApple = a + apples[i];
                if (testApple >= s && testApple <= t)
                {
                    applesHitHouse++;
                }
            }

            System.Console.WriteLine(applesHitHouse);

            for (int i = 0; i < oranges.Length; i++)
            {
                var testOrange = b + oranges[i];
                if (testOrange >= s && testOrange <= t)
                {
                    orangesHitHouse++;
                }
            }
            System.Console.WriteLine(orangesHitHouse);
        }

        static void Main(string[] args)
        {
            string[] st = new[] { "7", "11" };// Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = new[] { "5", "15" };// Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = new[] { "3", "2" };// Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apple = Array.ConvertAll(new[] { "-2", "2", "1" }, appleTemp => Convert.ToInt32(appleTemp));

            int[] orange = Array.ConvertAll(new[] { "5", "-6" }, orangeTemp => Convert.ToInt32(orangeTemp));

            countApplesAndOranges(s, t, a, b, apple, orange);
        }
    }
}
