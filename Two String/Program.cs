﻿using System.CodeDom.Compiler;
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

namespace Two_String
{
    class Program
    {
        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            return s1.Any(c => s2.Contains(c)) ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                System.Console.WriteLine(result);
                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            // textWriter.Close();
        }
    }
}
