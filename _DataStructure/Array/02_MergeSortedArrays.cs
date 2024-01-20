using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataStructure.Array
{
    internal class _02_MergeSortedArrays
    {
        public int[] MergeSortedArrays(int[] a, int[] b)
        {
            int aCount = 0;
            int bCount = 0;

            int length = a.Length + b.Length;
            int[] result = new int[length];

            for(int i = 0; i < length; i++)
            {
                if (aCount >= a.Length)
                {
                    result[i] = b[bCount];
                    bCount++;
                    continue;
                }
                else if (bCount >= b.Length)
                {
                    result[i] = a[aCount];
                    aCount++;
                    continue;
                }


                int aValue = a[aCount];
                int bValue = b[bCount];

                if(aValue < bValue)
                {
                    result[i] = aValue;
                    aCount++;
                }
                else
                {
                    result[i] = bValue;
                    bCount++;
                }
            }

            return result;
        }
    }
}
