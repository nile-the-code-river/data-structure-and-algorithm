namespace LeetCode.Easy
{
    internal class N94_BinaryTreeInorderTraversal : IProblem
    {
        public int Index => 94;

        public string Name => "Binary Tree Inorder Traversal";

        public string Description => "Given the root of a binary tree, return the inorder traversal of its nodes' values.";

        public string Link => "https://leetcode.com/problems/binary-tree-inorder-traversal";

        public DateTime SolvedDate => new DateTime(2024,08,27);

        public void TestCode()
        {
            TreeNode three = new TreeNode(3);
            TreeNode two = new TreeNode(2, three);
            TreeNode one = new TreeNode(1, null, two);

            TreeNode onlyOne = new TreeNode(1);
            IList<int> result = InorderTraversal(one);

         }

        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();

            if (root == null) return result;

            if (root.left == null)
            {
                result.Add(root.val);
            }
            else
            {
                IList<int> recurringResult = InorderTraversal(root.left);
                
                for (int i = 0; i < recurringResult.Count; i++)
                {
                    result.Add(recurringResult[i]);
                }

                result.Add(root.val);
            }
            
            if(root.right != null)
            {
                IList<int> recurringResult = InorderTraversal(root.right);

                for (int i = 0; i < recurringResult.Count; i++)
                {
                    result.Add(recurringResult[i]);
                }
            }

            if (result.Count == 0 && root != null)
            {
                result.Add(root.val);
            }

            return result;
        }
    }

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
