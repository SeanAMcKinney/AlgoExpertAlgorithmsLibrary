namespace AlgoExpertAlgorithmsLibrary
{
    public interface IBinarySearch
    {
        int BinarySearch(int[] array, int target);
    }

    public class BinarySearchProgram
        {
            // Function: takes in a sorted array of intergers as well as a target integer.  Will determine if the 
            // target intger is contained in the array and should return its index if it is, otherwise returns -1
            // Parameters example:
                                    // array: new int[] { 2, 3, 5, 6, 8 }
                                    // target: 6
            public static int BinarySearch(int[] array, int target)
            {
                // Write your code here.
                return BinarySearchHelper(array, target, 0, array.Length - 1);
            }

            private static int BinarySearchHelper(int[] array, int target, int leftPointer, int rightPointer)
            {
                while (leftPointer <= rightPointer)
                {
                    int middlePoint = (leftPointer + rightPointer) / 2;
                    int potentialMatch = array[middlePoint];
                    if (target == potentialMatch)
                    {
                        return middlePoint;
                    }
                    else if (target < potentialMatch)
                    {
                        rightPointer = middlePoint - 1;
                    }
                    else
                    {
                        leftPointer = middlePoint + 1;
                    }
                }
                return -1;
            }
        }
}