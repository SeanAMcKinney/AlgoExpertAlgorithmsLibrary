namespace AlgoExpertAlgorithmsLibrary
{
    public class TwoNumberSum
    {
        // Function: takes a non-empty array of distinct integers and an integer representing a target sum.  If any two numbers
        // in the input array sum up to the target sum, the function should return them and print out the equation.
        // If no two numbers sum up to the target sum, the function should return a message telling you that.
        // The target sum must be obtained by summing two different integers in the array.
        // This function will list ALL possible answers from combinations of two integers.

        public static void FindTwoNumberSum(int[] array, int targetSum)
        {
            int talley = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < array.Length - 1)
                {
                    int firstNum = array[i];
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        int secondNum = array[j];
                        {
                            if (firstNum + secondNum == targetSum)
                            {
                                System.Console.WriteLine($"{firstNum} + {secondNum} = {targetSum}\n");
                                talley++;
                                continue;
                            }
                            else if (firstNum + secondNum != targetSum)
                            {
                                continue;
                            }
                        }
                    }
                }
                if (talley == 0)
                {
                    System.Console.WriteLine($"No two integers in your array sum up to {targetSum}.\n");
                    return;
                }
            }
        }
    }
}