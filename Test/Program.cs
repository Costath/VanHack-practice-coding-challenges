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

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 1, 1};
            
            Console.WriteLine("Result = " + SubarraySum(arr));
        }

        public static long SubarraySum(List<int> arr)
        {
            List<int> aux = new List<int> { };
            aux.AddRange(arr);
            long result = 0;
            do
            {
                do
                {
                    result += aux.Sum();
                    aux.RemoveAt(aux.Count-1);
                } while (aux.Count > 0);
                
                arr.RemoveAt(0);
                aux.AddRange(arr);
            } while (arr.Count > 0);

        return result;
        }
    }
}
