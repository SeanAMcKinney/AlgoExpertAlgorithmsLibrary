namespace AlgoExpertAlgorithmsLibrary
{
    public class NodeDepthsProgram
        {
            // Function: Takes in a binary tree and returns the sum of it's nodes' depths.

            public static int NodeDepths(BinaryTree root)
            {
                // Recursive
                return nodeDepthsHelper(root, 0);
            }

            public static int nodeDepthsHelper(BinaryTree root, int depth)
            {
                if (root == null) return 0;
                return depth + nodeDepthsHelper(root.left, depth + 1) + nodeDepthsHelper(root.right, depth + 1);
            }

            public class BinaryTree
            {
                public int value;
                public BinaryTree left;
                public BinaryTree right;

                public BinaryTree(int value)
                {
                    this.value = value;
                    left = null;
                    right = null;
                }
            }
        }
}