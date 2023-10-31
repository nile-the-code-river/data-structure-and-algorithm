using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Playground
    {
        public void Run()
        {
            TestDelegate test = Method1;
            test += Method2;

            foreach (var del in test.GetInvocationList())
            {
                var res = del.DynamicInvoke();
                Console.WriteLine(del.Method);
                Console.WriteLine(res);
            }

            Console.Read();
        }

        private delegate bool TestDelegate();

        private bool Method1()
        {
            return true;
        }
        private bool Method2()
        {
            return false;
        }
    }
}
