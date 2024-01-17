using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N70_ClimbingStairs : IProblem
    {
        public int Index => 70;

        public string Name => "Climbing Stairs";

        public string Description => "Given a number of stairs, return the number of distinct ways of climbing chairs WHEN you can climb the stairs 1 step or 2 steps per time.";

        public string Link => "https://leetcode.com/problems/climbing-stairs/description/";

        public DateTime SolvedDate => new (2023,10,31);

        public void TestCode()
        {
            throw new NotImplementedException();
        }

        public int ClimbingStairs(int num)
        {
            int one = 1;
            int two = 1;
            int temp = 0;

            for(int i = 0; i < num; i++)
            {
                temp = one;
                one += two;
                two = temp;
            }

            return one;
        }
    }
}
