using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmTutorial.Searching
{
    public class SearchingProblems
    {
        public static int FirstRepeated(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j]) return arr[i];
                }
            }

            return 0;
        }


        public static int FirstRepeatedHashtable(int[] arr)
        {
            int size = arr.Length;

            Dictionary<int, int> result = new Dictionary<int, int>();

            for(int i = 0; i < size; i++)
            {
                if (result.ContainsKey(arr[i]))
                {
                    //int value = result[arr[i]];
                    //result[arr[i]] = value + 1;
                    return arr[i];
                }
                else
                {
                    result[arr[i]] = 1;
                }
            }

           

            return 0;
        }

        /// <summary>
        /// Given a sorted array list find the number of occurence of a number
        /// </summary>
        /// <param name="arr">The sorted array</param>
        /// <param name="key">The number to get it's occurence</param>
        /// <returns>The number of times the key occurred in the array</returns>
        public int findKeyCount(int[] arr,int key)
        {
            int size = arr.Length;
   
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == key)
                {
                    count++;
                }
            }

            return count;

        }


        /// <summary>
        /// In given list, in which nth element is the price of the stock on nth day.You are asked to buy once and sell once, on what date you will be buying and at what date you will be selling to get maximum profit
        /// </summary>
        /// <param name="arr">List of the stock</param>
        /// <returns>The maximum profit</returns>
        public int maxStockProfit(int[] arr)
        {
            int size = arr.Length;
            int maxProfit = 0;
            int buy = 0;
            int sell = 0;
            int currMin = 0;

            for(int i = 0; i < size; i++)
            {
                //check if the item at this point is lower than the current min
                if (arr[i] < arr[currMin])
                {
                    currMin = i;
                }

                //check if the the current profit is greater than the maximum profite
                if ((arr[i]-arr[currMin])> maxProfit){
                    //if the currrent profit is the max, set these values
                    maxProfit = arr[i] - arr[currMin];
                    buy = i;
                    sell = currMin;
                   
                }
            }

            Console.WriteLine("Purchase day is - " + buy + " at price " + arr[buy]);

            Console.WriteLine("Sell day is - " + sell + " at price" + arr[sell]);

            return maxProfit;

        }

        /// <summary>
        /// Given two sorted lists. Find the median of the arrays if they are combined to form a bigger list.
        /// </summary>
        /// <param name="firstArray">The first array</param>
        /// <param name="secondArray">The second array</param>
        /// <returns>The median of the two arrays</returns>
        public static int findMedian2Array(int[] firstArray,int[] secondArray)
        {
            int firstIndex = firstArray.Length;
            int secondIndex = secondArray.Length;

            //get the index of the median of the 2 arrays
            int medianIndex = ((firstIndex + secondIndex) + (firstIndex + secondIndex) % 2) / 2;
            int i=0, j = 0;
            int count = 0;

            while(count < medianIndex - 1)
            {
                //check if the firstIndex is not out of bound
                //if the first array is smaller, increase the index of the first element (i) else increase the index of the second element (j)
                if (i < firstIndex -1 && firstArray[i] < secondArray[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
                count++;
            }

            if (firstArray[i] < secondArray[j])
            {
                return firstArray[i];
            }
            else
            {
                return secondArray[j];
            }
        }


        /// <summary>
        /// In given list of 0’s and 1’s in which all the 0’s come before 1’s.Write an algorithm to find the index of the first 1 (Linear Search)
        /// </summary>
        /// <param name="arr">The array to be searched</param>
        /// <param name="value"></param>
        /// <returns>Index of the value</returns>
        public static int firstValueIndexLinearsearch(int[] arr,int value)
        {
            int size = arr.Length;

            for(int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }


        /// <summary>
        /// In given list of 0’s and 1’s in which all the 0’s come before 1’s.Write an algorithm to find the index of the first 1 (Binary Search)
        /// </summary>
        /// <param name="arr">The array to be searched</param>
        /// <param name="value"></param>
        /// <returns>Index of the value</returns>
        public static int firstValueIndexBinarySearch(int[] arr,int value)
        {
            int size = arr.Length;
            if (size==1 && arr[0] == 1)
            {
                return 0;
            }

            return BinarySearchUtil(arr,0, size - 1,value);
        }

        private static int BinarySearchUtil(int[] arr,int start,int end,int value)
        {
            if (end < start)
            {
                return -1;
            }
            int mid = (start + end) / 2;

            if (arr[mid] == value)
            {
                return mid;
            }
            else
            {
                if (arr[mid] < value)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
                return BinarySearchUtil(arr, start, end, value);
            }
        }

        /// <summary>
        /// Given an array of integers, find minimum absolute difference of adjacent element consider circular array
        /// </summary>
        /// <param name="arr">The adjacent array</param>
        /// <returns>The min difference</returns>
        public static int findMinDiffAdjacentArray(int[] arr)
        {
            int diff = 99999999;
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                diff = Math.Min(diff, Math.Abs(arr[i] - arr[i + 1]));
            }

            return diff;
        }

        /// <summary>
        /// In given two integer Lists; You have to check whether they are permutation of each other
        /// </summary>
        /// <param name="firstArr">The first array</param>
        /// <param name="SecondArr">The second array</param>
        /// <returns>True if they are a permutation of each other or false if otherwise</returns>
        public static bool checkPermutation(int[] firstArr, int[] SecondArr)
        {
            int firstSize = firstArr.Length;
            int secondSize = SecondArr.Length;

            if (firstSize != secondSize) return false;

            for(int i = 0; i < firstSize; i++)
            {
                if (firstArr[i] != SecondArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Given an array, you need to find balance point or balance index. An index is balanced index if the element in the left of it and elements in the right of it have same sum.
        /// </summary>
        /// <param name="arr">The array to find its balance</param>
        /// <returns>Index of the balance point</returns>
        public static int findBalancedPoint(int[] arr)
        {
            int size = arr.Length;
            int first = 0;
            int second = 0;

            for(int i = 0; i < size; i++)
            {
                first += arr[i];
            }

            for(int i = 0; i < size; i++)
            {
                if (first == second)
                {
                    return i;
                }
                
                if (i<size-1)
                {
                    first -= arr[i];
                }

                second += arr[i];
            }

            return -1;
        }
    }
}
