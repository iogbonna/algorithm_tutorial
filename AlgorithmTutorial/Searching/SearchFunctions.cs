using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.Searching
{
    public class SearchFunctions
    {
        /// <summary>
        /// Search for a value in an unsorted array
        /// </summary>
        /// <param name="arr">Array to be searched</param>
        /// <param name="value">The value to be search for in the array</param>
        /// <returns>true if the value is in the array or false if otherwise</returns>
        public static bool LinearUnsortedSearch(int[] arr,int value)
        {
            int size = arr.Length;
            for(int i = 0; i < size; i++)
            {
                if (arr[i] == value) return true;
            }
            return false;
        }

        /// <summary>
        /// Search for a value in a sorted array
        /// </summary>
        /// <param name="arr">The array to be search</param>
        /// <param name="value">The value being search for</param>
        /// <returns>true if the value is in the array or false if otherwise</returns>
        public static bool LinearSortedSearch(int[] arr,int value)
        {
            int size = arr.Length;
            for(int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                    return true;
                else if (arr[i] > value)
                    return false;
            }

            return false;
        }

        /// <summary>
        /// Using binary search algorithm to search for a value in an array
        /// </summary>
        /// <param name="arr">The array to be searched</param>
        /// <param name="value">The value in the array</param>
        /// <returns>true if the value is in the array or false if otherwise</returns>
        public static bool BinarySearch(int[] arr,int value)
        {
            int size = arr.Length;
            int low = 0;
            int high = size - 1;
            int mid;
            while(low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid] == value)
                {
                    return true;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {              high = mid - 1;
                }
            }

            return false;
        }
    }
}
