using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataStructure.Array
{
    internal class _01_ReverseAString
    {
        public string Reverse(string value)
        {
            string returnValue = string.Empty;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                returnValue.Append(value[i]);
            }

            return returnValue;
        }
    }
}
