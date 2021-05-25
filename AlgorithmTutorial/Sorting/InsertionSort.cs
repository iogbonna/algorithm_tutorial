using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.Sorting
{
    public  class InsertionSort
    {
        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void sort(int[] arr)
        {
            int size = arr.Length;
            int temp, j;
            for (int i = 1; i < size; i++)
            {
                temp = arr[i];
                //The outer loop is used to pick the value we want to insert into the sorted array in left.
                //The value we want to insert we have picked and saved in a temp variable
                //The inner loop is doing the comparison using the more() function. The values are shifted to the right until we find the proper position of the temp value for which we are doing this iteration
                for (j = i; j > 0 && more(arr[j - 1],temp); j--)
                {
                    arr[j] = arr[j - 1];
                }
                //Finally, the value is placed into the proper position. In each iteration of the outer loop, the length of the sorted array increase by one. When we exit the outer loop, the whole array is sorted.
                arr[j] = temp;
            }
        }
    }
}
