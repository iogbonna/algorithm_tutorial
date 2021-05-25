using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.Sorting
{
    public  class SortingProblems
    {
        /// <summary>
        /// Sort an array so that the min_value goes to the left while the max_values are arranged by the right
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="min_value">The value to be sorted by the left of the array</param>
        /// <param name="max_value">The value to be sorted by the right of the array</param>
        /// <returns name="count">The number of swaps required to complete the sorting</returns>
        public static int PartitionBI(int[] arr, int min_value,int max_value)
        {
           
            int size = arr.Length;

            int left = 0;
            int right = size - 1;
            int count = 0;

            while (left < right)
            {
                //from the left check if the values are equivalent to the min_value
                //stop at the position where the value is not equal to the min_value
                while (arr[left] == min_value)
                {
                    left++;
                }

                //from the right check if the values are equivalent to the max_value
                //stop at the position where the value is not equal to the max_value
                while(arr[right] == max_value)
                {
                    right--;
                }

                //if left position is less that the right position, swap the values
                if (left < right)
                {
                    swap(arr, left, right);
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Partition 3 variables in an array
        /// </summary>
        /// <param name="arr">The array to be partitioned</param>
        /// <param name="min_value">The minimum value which is the value that will be at the left</param>
        /// <param name="max_value">The maximum value which is the value at the right</param>
        public static void PartitionTRI(int[] arr, int min_value, int max_value)
        {
            int size = arr.Length;
            int left = 0;
            int right = size - 1;
            int i = 0;

            while (i <= right)
            {
                //move the min values to the left side of the array
                if (arr[i] == min_value)
                { 
                    swap(arr, i, left);
                    left += 1;
                    i++;
                }
                //move the max to the right side of the array
                else if (arr[i] == max_value)
                {
                    swap(arr, i, right);
                    right--;
                }
                else
                {
                    i++;
                }
               
            }


        }

        public static void SortEvenOodNumbers(int[] arr)
        {
            int size = arr.Length;
            int left = 0;
            int right = size - 1;

            while (left < right)
            {
                //if the value from the left is even then increment and move to the next element
                if (arr[left] % 2 == 0)
                {
                    left++;
                }
                else if (arr[right] % 2 == 1)
                {
                    //if the value from the right is odd, decrement and move to the next element
                    right++;
                }
                else
                {
                    swap(arr, left, right);
                    left++;
                    right++;
                }
            }

        }


        /// <summary>
        /// Sort an array according to the absolute difference from a given value
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="reference">The value for the calculation of the absolute difference</param>
        public static void AbsBubbleSort(int[] arr,int reference)
        {
            int size = arr.Length;
            for (int i=0;i<(size - 1); i++)
            {
                for (int j = 0; j < (size - 1 - i); j++)
                {
                    if (Math.Abs(arr[j] - reference) > Math.Abs(arr[j + 1] - reference))
                    {
                        swap(arr, j, j + 1);
                    }
                }
            }

        }

        public static int[] SortByArrayOrder(int[] arr,int[] orderArray)
        {
            int[] output = new int[arr.Length];

            int size = arr.Length;
            int orderSize = orderArray.Length;
            int index = 0;

            //use a dictionary to store the dictinct items in the array and their frequency
            Dictionary<int, int> ht = new Dictionary<int, int>();
            int value;
            for(int i = 0; i < size; i++)
            {
                //check if the item is already in the dictionary
                if (ht.ContainsKey(arr[i]))
                {
                    //if its already in the dictionary, increase the value by 1
                    value = ht[arr[i]];
                    ht[arr[i]] = value + 1;
                }
                else
                {
                    // if not add the item in the dictionary as a key and 1 as the value
                    ht[arr[i]] = 1;
                }
            }

            //iterate the second array and check if the values are already in the dictionary
            for(int j = 0; j < orderSize; j++)
            {
                //check if the key is already in the list
                if (ht.ContainsKey(orderArray[j]))
                {
                    //if the value from the second array is a key in the dictionary
                    //get the value which should correspond to the frequency of the item
                    value = ht[orderArray[j]];
                    for(int k = 0; k < value; k++)
                    {
                        output[index] = orderArray[j];
                        index++;
                    }
                    //remove the item from the dictionary
                    ht.Remove(orderArray[j]);
                }
            }

            //add the remainder of the items in the dictionary to the output array
            for(int i = 0; i < size; i++)
            {
                if (ht.ContainsKey(arr[i]))
                {
                    value = ht[arr[i]];

                    for (int k = 0; k < value; k++)
                    {
                        output[index] = arr[i];
                        index++;
                    }
                    //remove the item from the dictionary
                    ht.Remove(arr[i]);

                }
            }

            return output;
        }


        /// <summary>
        /// For the reduction, the smallest positive element in the array is selected and it is subtracted from all the other elements. Non zero elements are returned
        /// </summary>
        /// <param name="arr">The array to be reduced</param>
        /// <returns>Thre reduced array</returns>
        public static int[] ArrayReduction(int[] arr)
        {
            List<int> result = new List<int>();
            Array.Sort(arr);
            int reduction = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - reduction > 0)
                {
                    result.Add(arr[i] - reduction);
                }
            }

            return result.ToArray();
        }


        private static void swap(int[] arr,int index1,int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
