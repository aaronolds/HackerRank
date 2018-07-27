using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] values = { "{}[]()", "{{}", "{}}", "{{}{", "{}}}", "{{{((([[[]]])))}}}" };

            var braces = Braces(values);

            foreach (var s in braces)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

        static string[] Braces(string[] values)
        {
            var returnArray = new string[values.Count()];


            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];

                returnArray[index] = CheckString(value) ? "Yes" : "No";

            }

            return returnArray;
        }

        public static bool CheckString(string input)
        {   
            var pairs = new Dictionary<char, char>()
            {
                {'}', '{'},
                {']', '['},
                {')', '('}
            };
            var stack = new Stack<char>();

            foreach (var c in input)
            {
                if (pairs.ContainsValue(c))
                {
                    stack.Push(c);
                }

                if (pairs.ContainsKey(c) && (stack.Count == 0 || stack.Pop() != pairs[c]))
                { return false; }
            }
            return (stack.Count == 0);
        }
    }
}
