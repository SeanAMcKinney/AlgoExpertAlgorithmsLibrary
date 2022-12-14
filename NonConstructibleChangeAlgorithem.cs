using System;

namespace AlgoExpertAlgorithmsLibrary
{
    public class NonConstructibleChangeAlgorithem
    {
        // Function: given an array of positive integers representing the values of coins in your possession,
        // the function will retunr the minimum sum of money that you CANNOT create. Coins must be a positive
        // integer and do not have to be unique.
        // Parameter Example: new int[] { 1, 4, 2, 7 }

        public static int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);

            int currentChangeCreated = 0;
            foreach (var coin in coins)
            {
                if (coin > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }

                currentChangeCreated += coin;
            }

            return currentChangeCreated + 1;
        }
    }
}