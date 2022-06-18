using System;

namespace SortCommon
{
    public class SortCommon
    {
        /// <summary>
        /// Swap indexes i and j in array
        /// </summary>
        /// <param name="array">An array from which to swap elements i, j</param>
        /// <param name="i">Element to swap (source)</param>
        /// <param name="j">Element to swap (target)</param>
        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

