using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Climbing_the_leaderboard
{
    class Program
    {
        // Complete the climbingLeaderboard function below.
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var ranks = buildRanks(scores);
            var returnRank = new int[alice.Length];
            for (int i = 0; i < alice.Length; i++)
            {
                returnRank[i] = solve(scores, ranks, alice[i]);
            }
            return returnRank;
        }

        private static int solve(int[] scores, int[] ranks, int alice)
        {
            var aliceRank = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                // int middle = (lower + scores.Length) / 2;
                if (alice == scores[i])
                {
                    aliceRank = ranks[i];
                    break;
                }
                else if (alice < scores[i])
                {
                    aliceRank = ranks[i] + 1;
                }
            }
            return aliceRank;
        }

        static int[] buildRanks(int[] scores)
        {
            int[] ranks = new int[scores.Length];
            int rank = 1;
            for (int i = 0; i < ranks.Length; i++)
            {
                if (i > 0 && scores[i] != scores[i - 1])
                {
                    rank++;
                }
                ranks[i] = rank;
            }
            return ranks;
        }

        static void Main(string[] args)
        {
            int scoresCount = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int aliceCount = Convert.ToInt32(Console.ReadLine());
            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] result = climbingLeaderboard(scores, alice);

            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i]);
            }
        }
    }
}
