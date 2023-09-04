using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N20_ValidParentheses : IProblem
    {
        public int Index => 20;

        public string Name => "Valid Parentheses";

        public string Link => "https://leetcode.com/problems/valid-parentheses/";

        public DateTime SolvedDate => new DateTime(2023,09,04);

        public void BestCode()
        {
            throw new NotImplementedException();
        }

        public void TestCode()
        {
            ValidParenthesis("[]{]()");
        }

        public bool ValidParenthesis(string s)
        {
            char[] startParen = { '(', '{', '['};
            char[] endss = { ')', '}', ']'};


            string start = "{[(";
            string end = "}])";
            char cBefore = '\0';
            foreach (char c in s)
            {
                //Array.Find(startParen)


                //if(end.Any(x => x.Equals(cBefore)) && Array.Find(startParen, x => x.Equals(cBefore)))
                //{

                //}

                if (end.Any(x => x.Equals(cBefore)) || cBefore.Equals('\0'))
                {
                    cBefore = c;
                }
            }

            return true;
        }
    }
}
