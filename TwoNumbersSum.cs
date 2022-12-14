namespace AlgoExpertAlgorithmsLibrary
{
    public class TwoNumberSum
    {
        // Function: takes a non-empty array of distinct integers and an integer representing a target sum.  If any two numbers
        // in the input array sum up to the target sum, the function should return them in an aray, in any order.
        // If no two numbers sum up to the target sum, the function should return an empty array. The target sum must be obtained
        // by summing two different integers in the array.

        public static int[] FindTwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNum = array[j];
                    if (firstNum + secondNum == targetSum)
                    {
                        return new int[] { firstNum, secondNum };
                    }
                }
            }
            return new int[0];
        }
    }
}