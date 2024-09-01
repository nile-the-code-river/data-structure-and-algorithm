using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N101_SymmetricTree : IProblem
    {
        public int Index => 101;

        public string Name => "Symmetric Tree";

        public string Description => "Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).";

        public string Link => "https://leetcode.com/problems/symmetric-tree/";

        public DateTime SolvedDate => new DateTime(2024, 09, 01);

        public void TestCode()
        {
            throw new NotImplementedException();
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

        public bool IsSymmetric(TreeNode root)
        {
            // TreeNode(parameter) : =100 <= val  <=100
            int leftVal = -101;
            int rightVal = -101;


            while(root.left != null && root.right != null)
            {
                IsSymmetric(root.left);
                IsSymmetric(root.right);
                return false;
            }

            return true;
        }
    }
}
