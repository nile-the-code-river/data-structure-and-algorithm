namespace LeetCode
{
    internal interface IProblem
    {
        int Index { get; }
        string Name { get; }
        string Description { get; }
        string Link { get; }
        DateTime SolvedDate { get; }

        // Write codes to test each problem
        // static abstract void TestCode(); << Make it possible for N1_TwoSum.TestCode();
        void TestCode();
        //void BestCode(); // define parameters INSIDE the method 
    }
}
