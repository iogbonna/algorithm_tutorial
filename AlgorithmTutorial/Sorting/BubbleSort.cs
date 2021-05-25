using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.Sorting
{
    public class BubbleSort
    {
        private static bool more(int value1,int value2)
        {
            return value1 > value2;
        }

        public static void sort(int[] arr)
        {
            
            int size = arr.Length;

            int i, j, temp;
            for(i=0;i<(size - 1); i++)
            {
                //for each iteration, this moves the largest value to the last position
                //as that is done for the iteration, the size is reduced excluding the last position which already has the highest value
                //the next iteration continues without the last element and this continues until everything is sorted
                for(j=0;j<size - i - 1; j++)
                {
                    if (more(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void sort2(int[] arr)
        {
            int size = arr.Length;

            int i, j, temp, swapped = 1;

            //for each iteration, this moves the largest value to the last position
            //as that is done for the iteration, the size is reduced excluding the last position which already has the highest value
            //the next iteration continues without the last element and this continues until everything is sorted
            //but the algorithm has a swapped variable to check if the array is already sorted, if there is no swapping, that means that array is already sorted so there will be no need of continuing the looping and checking
            for (i=0;i<(size -1) && swapped == 1; i++)
            {
                swapped = 0;
                for (j = 0; j < size - i - 1; j++)
                {
                    if (more(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = 1;
                    }
                }
            }
        }
    }
}
