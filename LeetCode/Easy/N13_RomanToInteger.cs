namespace LeetCode.Easy
{
    enum Roman
    {
        I = 1,
        IV = 4,
        V = 5,
        IX = 9,
        X = 10,
        XL = 40,
        L = 50,
        XC = 90,
        C = 100,
        CD = 400,
        D = 500,
        CM = 900,
        M = 1000
    }

    internal class N13_RomanToInteger : IProblem
    {
        public int Index => 13;

        public string Name => "Roman To Integer";

        public string Description => "Given a string of Roman Number, convert it to regular number (Integer)";

        public string Link => "https://leetcode.com/problems/roman-to-integer/";

        public DateTime SolvedDate => new (2023, 08, 31);

        public void TestCode()
        {
            Console.WriteLine(IntToRoman(1491));
            Console.WriteLine(RomanToInt("MDCXCV"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public void BestCode()
        {
            throw new NotImplementedException();
        }

        // s is a valid roman numeral in the range [1, 3999].
        public int RomanToInt(string s)
        {
            int result = 0;
            char cBefore = new();

            for (int i = 0; i < s.Length; i++) // Skip first char
            {
                bool isLastChar = i.Equals(s.Length - 1);
                bool hasNoPreValue = cBefore.Equals('\0');
                char cNow = s[i];

                if (hasNoPreValue) // First char || cBeforeValue already added to results last time AND it is not the last char
                {
                    cBefore = cNow;

                    if (!isLastChar) continue;
                }

                int cNowValue = (int)Enum.Parse(typeof(Roman), cNow + "");
                int cBeforeValue = hasNoPreValue && isLastChar ? 0 : (int)Enum.Parse(typeof(Roman), cBefore + "");

                if (cNowValue <= cBeforeValue) // ex. MM, VI
                {
                    result += cBeforeValue;
                    cBefore = cNow;
                }
                else // ex. CM, XC = 90
                {
                    result += cNowValue - cBeforeValue;
                    cBefore = '\0';
                }

                if (i == s.Length - 1 && cNowValue <= cBeforeValue) result += cNowValue; // Last char value that is still not added
            }

            return result;
        }

        // * Bonus
        // Wrote this extra method
        public string IntToRoman(int input)
        {
            string result = string.Empty;

            Roman[] romans = (Roman[])Enum.GetValues(typeof(Roman));
            Array.Reverse(romans);

            // Tried to use for statement and use int i as an index for finding item in the enum, but failed.
            // so I used foreach, but it looks even better than for :) 
            foreach (Roman rm in romans)
            {
                int value = (int)rm;
                int count = input / value;

                result += string.Concat(Enumerable.Repeat(rm.ToString(), count));

                input -= value * count;
            }

            return result;
        }
    }
}
