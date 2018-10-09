using System;
using System.Collections.Generic;

namespace NumberCruncher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 5, 7, 9, 12, 16, 22, 26, 33, 40 };
            Console.WriteLine(NumberUtility.SumOfEvens(nums));
            Console.ReadLine();
        }
    }
}
