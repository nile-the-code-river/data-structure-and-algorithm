using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N21_MergeTwoSortedLists : IProblem
    {
        public int Index => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Link => throw new NotImplementedException();

        public DateTime SolvedDate => throw new NotImplementedException();

        public void BestCode()
        {
            throw new NotImplementedException();
        }

        public void TestCode()
        {
            throw new NotImplementedException();
        }

        // All wrong
        public void MergeTwoSortedLists(List<int> a, List<int> b)
        {
            List<int> newList = new List<int>();
            Queue<int> wait = new Queue<int>();
            while (true)
            {

            }

        }

        public List<int> MergeTwoSortedLists_2(List<int> a, List<int> b)
        {
            a.AddRange(b);
            a.Sort();
            return a;
        }
    }
}
