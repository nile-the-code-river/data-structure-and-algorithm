using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal interface IProblem
    {
        int Index { get; }
        string Name { get; }
        string Link { get; }
        DateTime SolvedDate { get; }

        // Write codes to test each problem
        static void TestCode() { }
    }
}
