using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithims
{
    public class SortingAlgorithms
    {
        public static string displayArray(int[] array)
        {
            string solution = "";
            for (int i = 0; i < array.Length; i++)
            {
                solution += array[i] + " ";
            }
            return solution;
        }
        public static void insertionSort(int[] array)
        {
            int i, j, temp;
            for (i = 1; i < array.Count(); i++)
            {
                j = i;

                while (j > 0 && array[j - 1] > array[j])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }

            }
        }


        public static void merge(int[] arr, int left, int middle, int right)
        {
            // Find sizes of two subarrays to be merged
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[middle + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void mergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Sort first and
                // second halves
                mergeSort(arr, left, middle);
                mergeSort(arr, middle + 1, right);

                // Merge the sorted halves
                merge(arr, left, middle, right);
            }
        }


    }

}

