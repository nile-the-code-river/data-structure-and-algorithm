namespace LeetCode.NonLeetcode
{
    internal class N0_FirstRecurringCharacter : IProblem
    {
        public int Index => throw new NotImplementedException();

        public string Name => "First Recurring Character";

        public string Description => "FROM UDEMY COURSE. Given an array of chars, find first recurring character.";

        public string Link => "https://www.udemy.com/course/master-the-coding-interview-data-structures-algorithms/learn/lecture/12314730#overview";

        public DateTime SolvedDate => throw new NotImplementedException();

        public void TestCode()
        {
            var ans1 = FirstRecurringCharacter(new char[] { 'i', 'l', 'o', 'v', 'e', 'y', 'o', 'u', '!' });
            var ans2 = FirstRecurringCharacter(new char[] { '2', '1', '1', '2', '3', '5', '1', '2', '4' });

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }

        public char FirstRecurringCharacter(char[] chars)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsValue(chars[i]))
                    return chars[i];

                dict.Add(i, chars[i]);
            }

            return default;
        }

    }
}
