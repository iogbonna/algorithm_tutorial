using System;
using AlgorithmTutorial.IntegerAlgorithms;
using AlgorithmTutorial.Sorting;

namespace AlgorithmTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!");

            //int[] nums = new int[] { 3, 2, 2, 3 };
            //nums = Array.FindAll(nums, i => i != 3);

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("The index of 7 using sequential search: " + SearchUtil.sequential_search(arr, arr.Length,7));

            Console.WriteLine("The index of 7 using binary search: " + SearchUtil.binary_search(arr, arr.Length, 7));

            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            BubbleSort.sort2(array);
            Console.Write("Bubble sort : ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            int[] array2 = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.WriteLine();
            SelectionSort.sort(array2);
            Console.Write("Insertion sort : ");
            for (int i = 0; i < array2.Length; i++)
                Console.Write(array2[i] + " ");


            int[] array1 = new int[] { 0, 1, 1, 0, 1, 0, 1, 1, 0, 0,0, 1 };
            SortingProblems.PartitionBI(array1,0,1);

            Console.WriteLine();
            Console.Write("Partitioning : ");
            for (int i = 0; i < array1.Length; i++)
                Console.Write(array1[i] + " ");

            int[] arr2 = new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            SortingProblems.PartitionTRI(arr2, 0, 2);

            Console.WriteLine();
            Console.Write("PartitioningTRI : ");
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + " ");

            array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5};
            SortingProblems.AbsBubbleSort(array, 5);
            printArray(array);


            arr = new int[] { 2, 1, 2, 5, 7, 1, 9, 3, 6, 8,8 };
            arr2 = new int[] { 2, 1, 8, 3 };

            int[] result = SortingProblems.SortByArrayOrder(arr, arr2);
            Console.Write("SortByArrayOrder : ");
            printArray(result);

        }


        static void printArray(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
           
        }
    }
}
