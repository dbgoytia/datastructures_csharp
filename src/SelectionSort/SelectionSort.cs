using System;
using SortCommon;

namespace SelectionSort
{
    /// <summary>
    /// Represent an implementation of the Selection sort algorithm
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
		/// Sorting implementation through selection sort algorithm
		/// </summary>
		/// <param name="arr"></param>
        public static void Sort(int [] arr)
        {
            for (int partIndex = arr.Length - 1; partIndex > 0; partIndex --)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i ++)
                {
                    if (arr[i] > arr[largestAt])
                    {
                        largestAt = i;
                    }
                }
                SortCommon.SortCommon.Swap(arr, largestAt, partIndex);
            }
        }

    }
}
