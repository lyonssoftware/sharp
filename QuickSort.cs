// example of Quicksort in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
// quicksort namespace
namespace Quicksort
{
   // class name
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            string[] unsorted = { "z","e","x","c","m","q","a"};
 
            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
             // print the sorted cslue 
                Console.Write(unsorted[i] + " ");
            }
         // print out the array 
            Console.WriteLine();
 // commentary 
            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);
 
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
             // print the unsorted
                Console.Write(unsorted[i] + " ");
            }
 // print the insorted list 
            Console.WriteLine();
 // reas the line 
            Console.ReadLine();
        }
 // main function 
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
// initialed the left and right variable 
            int i = left, j = right;
// set the pivot 
            IComparable pivot = elements[(left + right) / 2];
 
         
            // while the elements are in
            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                // check the the element in the array then pivot
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
 // compare if the current 
                if (i <= j)
                {
                    // set the new
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
 
                    i++;
                    j--;
                }
            }
 
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
 
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
 
    }
}
