using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N14_LongestCommonPrefix : IProblem
    {
        public int Index => 14;

        public string Name => "Longest Common Prefix";

        public string Link => "https://leetcode.com/problems/longest-common-prefix/";

        public DateTime SolvedDate => new(2023, 09, 01);

        public void BestCode()
        {
            throw new NotImplementedException();
        }

        public void TestCode()
        {
            var input = new string[] { "flower", "flow", "fly" };
            var sdd = LongestCommonPrefix(input);
            foreach (var item in sdd)
            {
                Console.Write(item);
            }
            Console.WriteLine(  );
            input = new string[] { "aa", "ab" };
            sdd = LongestCommonPrefix(input);
            foreach (var item in sdd)
            {
                Console.Write(item);
            }
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string common = strs[0];

            //Word
            for (int i = 0; i < strs.Length - 1; i++)
            {
                string compareWord = strs[i + 1]; // Compare to next word
                
                if (common.Length > compareWord.Length) common = common.Substring(0, compareWord.Length);

                //Letter
                for (int compareAt = 0; compareAt < compareWord.Length; compareAt++)
                {
                    if (compareAt >= common.Length) break;

                    if (!common[compareAt].Equals(compareWord[compareAt]))
                    {
                        common = common.Substring(0, compareAt);
                        break;
                    }

                }

                if (common.Equals(string.Empty)) break;
            }

            return common;
        }

        public string LongestCommonPrefix_Optimized(string[] strs)
        {
            string common = strs[0];

            //Word
            for (int i = 0; i < strs.Length; i++)
            {
                string compareWord = strs[i];

                if (common.Length > compareWord.Length) common = common.Substring(0, compareWord.Length);

                //Letter
                for (int compareAt = 0; compareAt < compareWord.Length; compareAt++)
                {
                    if (!common[compareAt].Equals(compareWord[compareAt]))
                    {
                        char mismatchingLetter = common[compareAt];
                        common = common.Split(mismatchingLetter).First();
                        break;
                    }

                }

                if (common.Equals(string.Empty))
                    return common;
                //common = common.Union(strs[i]).ToArray();


                //result.IndexOfAny();
                // result.SelectMany();
                // result.ToLookup();
                // result.ToDictionary();
                // result.ToHashSet();

                // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-7.0
                // https://www.geeksforgeeks.org/hashset-in-c-sharp-with-examples/
                // https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
                // https://stackoverflow.com/questions/9248714/c-sharp-union-of-strings
                // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.union?view=net-7.0

                // strs[i]
            }

            return common.ToString();
        }
    }
}
