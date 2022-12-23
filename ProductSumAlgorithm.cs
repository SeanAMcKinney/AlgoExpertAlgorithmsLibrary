using System.Collections.Generic;

namespace AlgoExpertAlgorithmsLibrary
{
    public class ProductSumAlgorithm
    {
        // takes a "special" array and returns it's product sum. 
        /* sample: { "array": [5, 2, [7, -1], 3, [6, [-13, 8], 4]] }  output: 12 */
        // Calculated as: 5 + 2 + 2 * (7 - 1) + 3 + 2 * (6 + 3 * (-13 + 8) + 4)

        public static int ProductSum(List<object> array)
        {
            return productSumHelper(array, 1);
        }

        public static int productSumHelper(List<object> array, int multiplier = 1)
        {
            int sum = 0;
            foreach (object el in array)
            {
                if (el is IList<object>)
                {
                    sum += productSumHelper((List<object>)el, multiplier + 1);
                }
                else
                {
                    sum += (int)el;
                }
            }
            return sum * multiplier;
        }
    }
}