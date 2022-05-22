using System;
namespace BubbleSort
{
    /// <summary>
    /// Represents an implementation of the BubbleSort algorithm
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Swap indexes i and j in array
        /// </summary>
        /// <param name="array">An array from which to swap elements i, j</param>
        /// <param name="i">Element to swap (source)</param>
        /// <param name="j">Element to swap (target)</param>
        private static void Swap(int[] array, int i, int j)
        {
            if(i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

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
                        Swap(array, i, i + 1);
                    }

                }
            }
        } 
  
    }
}
