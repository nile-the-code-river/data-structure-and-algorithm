namespace _DataStructure
{
    class Program
    {
        public static int Main()
        {
            //Array._00_Array array = new Array._00_Array();

            //array.Push("test");
            //var test = array.Get(0);

            //Console.WriteLine(test);

            Array._02_MergeSortedArrays arrays = new Array._02_MergeSortedArrays();

            int[] a = { 0, 3, 7, 9 };
            int[] b = { 1, 2, 4, 10 };

            int[] result = arrays.MergeSortedArrays(a, b);

            foreach (var item in result.ToList())
            {
                Console.Write(item + " ");

            }

            return 0;
        }
    }
}