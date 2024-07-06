using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NonLeetcode
{
    internal class _00_FirstRecurringCharacter : IProblem
    {
        public int Index => throw new NotImplementedException();

        public string Name => "First Recurring Character";

        public string Description => "FROM UDEMY COURSE. Given an array of chars, find first recurring character.";

        public string Link => "https://www.udemy.com/course/master-the-coding-interview-data-structures-algorithms/learn/lecture/12314730#overview";

        public DateTime SolvedDate => throw new NotImplementedException();

        public void TestCode()
        {
            FirstRecurringCharacter(new char[] { 'i', 'l', 'o', 'v', 'e', 'y', 'o', 'u', '!' });
        }

        public char FirstRecurringCharacter(char[] chars)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();

            for(int i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsValue(dict[i]))
                    return dict[i];

                dict.Add(i, chars[i]);
            }

            return default;
        }

    }
}
