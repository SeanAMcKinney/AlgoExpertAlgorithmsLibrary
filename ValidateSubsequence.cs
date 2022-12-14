using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpertAlgorithmsLibrary
{
    public class ValidateSubsequence
    {
        //  Function: Given two non-empty arrays of integers, write a function that determines whether the second array is a
        //  subsequence of the first one. 

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int seqPointer = 0;
            foreach (var item in array)
            {
                if (seqPointer == sequence.Count)
                {
                    break;
                }
                if (sequence[seqPointer] == item)
                {
                    seqPointer++;
                }
            }
            return seqPointer == sequence.Count;
        }
    }
}
