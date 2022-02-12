using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MinOfArray
{
    public static class ArrayHelper
    {
        public static int MinOfArray(int[] array, int size, int index = 0)
        {
            if (array is null || array.Length == 0)
            {
                return -1;
            }

            if (index == size - 1)
            {
                return array[index];
            }

            int min = MinOfArray(array, size, index + 1);

            if (array[index] < min)
            {
                return array[index];
            }
            else
            {
                return min;
            }
        }
    }
}


