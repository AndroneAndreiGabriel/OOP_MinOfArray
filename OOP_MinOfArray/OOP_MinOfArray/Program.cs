using System;

namespace OOP_MinOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
            int min = ArrayHelper.MinOfArray(array, array.Length);
            Console.WriteLine($"Min of vector is: {min}");
        }
    }
}
