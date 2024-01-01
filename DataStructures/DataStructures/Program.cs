using DataStructures.Basic;

namespace DataStructures
{
    internal class Program
    {
        // Call methods to test within this method
        static void Main(string[] args)
        {
            ReverseAString rs = new ReverseAString();
            string s = rs.Reverse("Hi this Ava.");

            global::System.Console.WriteLine(s);
        }
    }
}