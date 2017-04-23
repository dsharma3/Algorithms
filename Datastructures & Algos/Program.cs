/*
    This examples are tested and build using .net core 1.1 framework.
    Follow below steps to run this program
    1) open Command prompt
    2) Navigate to the directory
    3) Run command --> dotnet run.
 */

using System;
using System.Linq;
using Sorting;

namespace Algorithms
{
    class Program
    {        
        static void Main(string[] args)
        {
            ISorting sortingObj;          

            Console.WriteLine("Please enter the array seperated by space to sort.");

            var numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            // if you must have it as an array...
            int[] arr = numbers.ToArray();                  

            Console.WriteLine("Please enter the type of sorting required.");
            string arg =Console.ReadLine();
            
            var algSelector = new SortAlgorithmSelector();
            sortingObj = algSelector.GetAlgorithmObjByName(arg);
            arr = sortingObj.Sort(arr);

            Console.WriteLine("Sorted array");

            for(int i = 0; i< arr.Length - 1; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
        }
    }
}
