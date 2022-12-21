using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgoExpertAlgorithmsLibrary
{
    public class SortedSquaredArrayAlgorithem
    {
        // Function: takes in a non-empty array of integers that are sorted in ascending order and returns a new array of
        // the same length with the squares of the original integers also sorted in ascending order.

        public static int[] SortedSquaredArray(int[] array)
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

            Array.Sort(sortedSquares);
            Console.WriteLine($"The squares from your array are: \n");
            foreach (int squareInt in sortedSquares)
            {
                Console.WriteLine(squareInt);
            }
            return sortedSquares;
        }
    }
}