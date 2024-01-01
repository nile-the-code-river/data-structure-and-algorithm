using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Basic
{

    internal class CustomArray
    {

        private string[] _myArray = new string[4];

        public string Get(int index)
        {
            return _myArray[index];
        }

        public void Push(string item)
        {
            _myArray[_myArray.Count()] = item;
        }
    }

}
