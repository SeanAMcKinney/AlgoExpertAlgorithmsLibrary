using System.Collections.Generic;

namespace AlgoExpertAlgorithmsLibrary
{
    public class BranchSumsAlgorithm
    {
        //  Function: takes in a binary tree and returns a list of its branch sums ordered from leftmost
        //  branch sum to rightmost branch sum. 
        //  

        public class BinaryTree
        {
            public int Value;
            public BinaryTree Left;
            public BinaryTree Right;

            public BinaryTree(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public static List<int> BranchSums(BinaryTree root)
        {
            List<int> sums = new List<int>();
            CalculateBranchSums(root, 0, sums);
            return sums;
        }

        public static List<int> CalculateBranchSums(BinaryTree node, int runningSum, List<int> sums)
        {
            if (node == null) return sums;

            int newRunningSum = runningSum + node.Value;
            if (node.Left == null && node.Right == null)
            {
                sums.Add(newRunningSum);
                System.Console.WriteLine(sums);
                return sums;
            }

            CalculateBranchSums(node.Left, newRunningSum, sums);
            CalculateBranchSums(node.Right, newRunningSum, sums);
            return sums;
        }
    }
}