using System;

namespace AlgorithmTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("The index of 7 using sequential search: " + SearchUtil.sequential_search(arr, arr.Length,7));

            Console.WriteLine("The index of 7 using binary search: " + SearchUtil.binary_search(arr, arr.Length, 7));

           
        }
    }
}
