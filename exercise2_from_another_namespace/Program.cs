using System;
using System.Linq;

namespace exercise2_from_another_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}
