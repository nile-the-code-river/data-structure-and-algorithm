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

        public void TestCode()
        {
            Console.WriteLine(ValidParenthesis("{[]}"));
            Console.WriteLine(ValidParenthesis("]"));
            Console.WriteLine(ValidParenthesis("[]{}()"));
        }

        public bool BestCode(string s)
        {
            Stack<char> expected = new();

            foreach (char c in s)
            {
                // if is faster than switch in this case
                if (c.Equals('('))
                {
                    expected.Push(')');
                    continue;
                }
                else if (c.Equals('{'))
                {
                    expected.Push('}');
                    continue;
                }
                else if (c.Equals('['))
                {
                    expected.Push(']');
                    continue;
                }

                if (expected.Count == 0 || !expected.Pop().Equals(c)) // using Pop() is important. not Peek()
                    return false;
            }

            return expected.Count == 0;
        }

        public bool ValidParenthesis(string s)
        {
            char[] start    = { '(', '{', '['};
            char[] end      = { ')', '}', ']'};

            Stack<char> unwrappedPars = new();

            foreach (char c in s)
            {
                bool isStartChar = Array.Exists(start, x => x.Equals(c));

                if (isStartChar || (unwrappedPars.Count.Equals(0) && isStartChar))
                    unwrappedPars.Push(c);
                else if (!unwrappedPars.Count.Equals(0) && c.Equals(end[Array.IndexOf(start, unwrappedPars.Peek())]))
                    unwrappedPars.Pop();
                else
                    return false;
            }

            return unwrappedPars.Count.Equals(0);
        }
    }
}
