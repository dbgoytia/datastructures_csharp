using System;

namespace InsertionSort
{
    public class InsertionSort
    {
        /// <summary>
		/// Sorting implementation through selection sort algorithm
		/// </summary>
		/// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            for (int partIndex = 1; partIndex < arr.Length; partIndex++)
            {
                int curUnsorted = arr[partIndex];
                int i = 0;
                // Find correct place
                for (i = partIndex; i > 0 && arr[i - 1] > curUnsorted; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[i] = curUnsorted;
            }
        }
    }
}