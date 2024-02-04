using _DataStructure.HashTable;

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

            //Array._02_MergeSortedArrays arrays = new Array._02_MergeSortedArrays();

            //int[] a = { 0, 3, 7, 9 };
            //int[] b = { 1, 2, 4, 10 };

            //int[] result = arrays.MergeSortedArrays(a, b);

            //foreach (var item in result.ToList())
            //{
            //    Console.Write(item + " ");

            //}

            HashTable._00_HashTable<string, string> hashTable = new HashTable._00_HashTable<string, string>();

            hashTable.Push("01","test1");
            hashTable.Push("02","test2");

            Console.WriteLine(hashTable.Get("01"));

            return 0;
        }
    }
}