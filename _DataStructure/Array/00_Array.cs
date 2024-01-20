using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataStructure.Array
{
    // string
    internal class _00_Array
    {
        private int _filledLength = -1;
        private int _maxLength = 10;

        private string[] _array;

        public _00_Array()
        {
            _array = new string[_maxLength];
        }

        public string Get(int index)
        {
            if (index < 0
                || index > _filledLength)
                return string.Empty;

            return _array[index];
        }

        public void Push(string value)
        {
            _filledLength += 1;

            _array[_filledLength] = value;
        }

        public string Pop()
        {
            string returnValue = _array[_filledLength];

            _array[_filledLength] = string.Empty;
            _filledLength -= 0;

            return returnValue;
        }

        public void RemoveAt(int index)
        {
            if (index < 0
                || index > _filledLength)
                return;

            for (int i = index; i < _filledLength; i++)
            {
                _array[i] = _array[i + 1];
            }

            if (_filledLength == index) return;

            _array[_filledLength] = string.Empty;
            _filledLength -= 1;
        }
    }
}
