using System;
using System.Collections.Generic;

namespace AlgoExpertAlgorithmsLibrary
{
    public interface IIsValidSubSequence
    {
        bool IsValidSubSequence(List<int> array, List<int> sequence);
    }

    public class ValidateSubsequenceAlgorithm //: IIsValidSubSequence
    {
        //  Function: Given two non-empty arrays of integers, write a function that determines whether the second array is a
        //  subsequence of the first one. 

        public static bool IsValidSubSequence(List<int> array, List<int> sequence)
       //public bool IsValidSubSequence(List<int> array, List<int> sequence)
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

            if (seqPointer == sequence.Count)
            {
                Console.WriteLine($"True:  Your sequence is a subsequence of the initial array.\n");
            }
            else
            {
                Console.WriteLine($"False:  Your sequence is not a subsequence of the initial array.\n");
            }
            return seqPointer == sequence.Count;
        }
    }
}
