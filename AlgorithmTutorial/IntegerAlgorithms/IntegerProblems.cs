using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTutorial.IntegerAlgorithms
{
    public class IntegerProblems
    {
        public static int Reverse(int x)
        {
            //this will store the result
            int reverse = 0;

            int prev_num = 0;
            while (x != 0)
            {
                //using modulus get the remainder of the x value divided by 10
                int remainder = x % 10;

                //multiply the reverse by 10 
                reverse = (reverse * 10);

                //add the remainder to the reversed number
                reverse = reverse + remainder;

                if ((reverse-remainder)/10 != prev_num)
                {
                    return 0;
                }

                //get a new x by dividing the existing x by 10
                prev_num = reverse;

                x = x / 10;
            }

            //if (reverse > int.MaxValue || reverse < int.MinValue)
            //{
            //    return 0;
            //}
            return reverse;
        }
    }
}
