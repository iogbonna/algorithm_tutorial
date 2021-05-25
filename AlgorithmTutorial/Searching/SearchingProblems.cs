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

            //for(int i = 0; i < result.Count; i++)
            //{
            //    if (result.ElementAt(i).Value > 1)
            //        return result.ElementAt(i).Key;
            //}

            return 0;
        }
    }
}
