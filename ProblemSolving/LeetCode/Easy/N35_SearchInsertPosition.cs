using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N35_SearchInsertPosition : IProblem
    {
        public int Index => 35;

        public string Name => "Search Insert Position";

        public string Description => "Given an sorted array of numbers and a target number, return the hypothetical index of the target number if it was in the array.";

        public string Link => "https://leetcode.com/problems/search-insert-position/description/";

        public DateTime SolvedDate => new (2023, 09, 14);

        public void TestCode()
        {
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 7));
        }

        public int SearchInsertPosition(int[] nums, int target)
        {
            if (nums[0] >= target) return 0;

            for (int i = 0; i < nums.Length - 1; i++)
                if (nums[i] < target && nums[i + 1] >= target)
                    return i + 1;

            return nums.Length;
        }

        public int SearchInsertPosition_Optmz(int[] nums, int target)
        {
            if (nums[0] >= target) return 0;
            return Array.IndexOf(nums, nums.Where(x => x < target).Last()) + 1;
        }
    }
}
