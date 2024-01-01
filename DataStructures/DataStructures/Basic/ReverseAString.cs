using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Basic
{
    internal class ReverseAString
    {
        public string Reverse(string item)
        {
            string newString = string.Empty;

            for(int i = item.Length - 1; i >= 0; i--)
            {
                newString += item[i];
            }

            return newString;
        }
    }
}
