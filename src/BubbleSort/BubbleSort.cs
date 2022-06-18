using System;
using SortCommon;

namespace BubbleSort
{
    /// <summary>
    /// Represents an implementation of the BubbleSort algorithm
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Implements the BubbleSort sorting algorithm.
        /// </summary>
        /// <param name="array">Represents an array to sort.</param>
        public static void Sort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex > 0; partIndex-- )
            {
                // Iterate until reaching the wall
                for (int i = 0; i < partIndex; i++)
                {
                    // i + j represents "j"
                    if (array[i] > array[i + 1])
                    {
                        SortCommon.SortCommon.Swap(array, i, i + 1);
                    }

                }
            }
        } 
  
    }
}
