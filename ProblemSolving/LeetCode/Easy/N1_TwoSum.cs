using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N1_TwoSum : IProblem
    {
        public int Index => 1;

        public string Name => "TwoSum";

        public string Link => "https://leetcode.com/problems/two-sum/";

        public DateTime SolvedDate => new DateTime(2023, 08, 30);

        public static void TestCode()
        {
            N1_TwoSum n1 = new N1_TwoSum();
            int[] arr = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int[] res = n1.TwoSum_Optimizied(arr, 11);

            foreach (int r in res)
                Console.WriteLine(r);
        }

        // Easy Answer O(n^2)
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] result = { i, j };
                        return result;

                    }
                }
            }
            return new int[0];
        }

        // Optimized O(n)
        public int[] TwoSum_Optimizied(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int match = target - nums[i];

                if (dict.ContainsKey(match))
                {
                    result[0] = dict[match];
                    result[1] = i;
                    return result;
                }

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            return new int[0];
        }
    }
}
