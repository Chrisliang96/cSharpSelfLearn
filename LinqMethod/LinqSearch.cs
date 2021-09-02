using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharpSelfLearn.LinqMethod
{
    public class LinqSearch
    {
        public static void LinqSearchTest()
        {
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            var array = (from i in numbers
                where i < 5 && i > 0
                select i).ToArray();
            Console.WriteLine(array.Length);
        }
    }
}