using System;

namespace SelectionSort
{
    /// <summary>
    /// Representas an implementation of the Selection sort algorithm
    /// </summary>
    public class SelectionSort
    {

        /// <summary>
        /// Swap indexes i and j in array
        /// </summary>
        /// <param name="array">An array from which to swap elements i, j</param>
        /// <param name="i">Element to swap (source)</param>
        /// <param name="j">Element to swap (target)</param>
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

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
                Swap(arr, largestAt, partIndex);
            }
        }

    }
}
