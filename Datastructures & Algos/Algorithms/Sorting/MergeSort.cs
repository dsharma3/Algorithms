/*
    It will recurse all the nodes on the left side of a node underneath a node and after that it will span a right node.

 */

using System;
namespace Sorting{

    public class MergeSort: ISorting
    {
        private void Sort(int[] array, int l, int r)
        {
           if (l < r)
            {
                // Find the middle point
                int m = (l+r)/2;
    
                Console.WriteLine("l={1},r={2},m={0}",m,l,r);                
                // Sort first and second halves
                Sort(array, l, m);
                Console.WriteLine("Second Line");
                Sort(array , m+1, r);
    
                // Merge the sorted halves
                merge(array, l, m, r);
            }            
        }

        private void PrintArray(int[] array)
        {
            for(int i = 0; i< array.Length - 1; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
        
        void merge(int[] arr, int l, int m, int r)
        {
            Console.WriteLine("Inside merge => l={1},m={0},r={2}",m,l,r);  
            // Find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;
    
            /* Create temp arrays */
            int[] L = new int [n1];
            int[] R = new int [n2];
    
            /*Copy data to temp arrays*/
            for (int f=0; f<n1; ++f)
                L[f] = arr[l + f];
            for (int e=0; e<n2; ++e)
                R[e] = arr[m + 1+ e];
    
    
            /* Merge the temp arrays */
    
            // Initial indexes of first and second subarrays
            int i = 0, j = 0;
    
            // Initial index of merged subarry array
            int k = l;
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
    
            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
    
            /* Copy remaining elements of L[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

            PrintArray(arr);
        }

        public int[] Sort(int[] array)
        {
             Sort(array, 0, array.Length - 1);
             return array;
        }
    }
}
