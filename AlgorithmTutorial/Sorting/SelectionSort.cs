using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.Sorting
{
    public class SelectionSort
    {
        public static void sort(int[] arr)
        {
            int size = arr.Length;
            int i, j, max, temp;
            for (i = 0; i < size - 1; i++)
            {
                max = 0;
                //loops through the array, at each iteration, it selects the largest value and moves it to the back
                //max represents the location of the largest value. For each iteration, it starts from 0
                //the inner loop compares all the elements to check if an element is greater than the element at zero
                for (j = 1; j < size - 1 - i; j++)
                {
                    if (arr[j] > arr[max])
                    {
                        max = j;
                    }
                }
                //temp holds the value at the end of the array
                temp = arr[size - 1 - i];
                //the largest value is places at the end
                arr[size - 1 - i] = arr[max];
                //the temp value is place at the former location of the largest value
                arr[max] = temp;
            }
        }
    }
}
