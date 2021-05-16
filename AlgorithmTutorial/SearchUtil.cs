using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial
{
    public  class SearchUtil
    {
        public static int sequential_search(int[] arr,int size,int value)
        {

            for(int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                    return i;
            }

            return -1;

        }

        public static int binary_search(int[] arr, int size, int value)
        {
            int mid;
            int low = 0;
            int high = size - 1;

            while(low <= high)
            {
                mid = low + (high - low) / 2;

                if (arr[mid] == value)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] < value)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

           

            return -1;
        }
    }
}
