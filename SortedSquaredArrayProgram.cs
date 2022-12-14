﻿using System;

namespace AlgoExpertAlgorithmsLibrary
{
    public class SortedSquaredArrayProgram
        {
            // Function: takes in a non-empty array of integers that are sorted in ascending order and returns a new array of
            // the same length with the squares of the original integers also sorted in ascending order.

            public int[] SortedSquaredArray(int[] array)
            {
                // Write your code here.
                int[] sortedSquares = new int[array.Length];
                int smallestValuePointerIndex = 0;
                int largestValuePointerIndex = array.Length - 1;

                for (int index = array.Length - 1; index >= 0; index--)
                {
                    int smallerValue = array[smallestValuePointerIndex];
                    int largerValue = array[largestValuePointerIndex];

                    if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                    {
                        sortedSquares[index] = smallerValue * smallerValue;
                        smallestValuePointerIndex++;
                    }
                    else
                    {
                        sortedSquares[index] = largerValue * largerValue;
                        largestValuePointerIndex--;
                    }
                }
                return sortedSquares;
            }
        }
}