using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueElement
{
    class Program
    {
        //Using XOR
        /// <summary>
        /// Logical operation XOR provide the BEST SOLUTION to solve this problem. 
        /// In fact, with the 2 XOR properties below, applying XOR of all elements of our array will gives us the result:
        /// - XOR of a number with itself is 0. 
        /// - XOR of a number with 0 is number itself.
        /// --> Time Complexity: O(n)
        /// --> Space Complexity: O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int getUniqueElement1(int[] arr)
        {
            int n = arr.Length;
            int result = arr[0];
            for (int i = 1; i < n; i++)
                result = result ^ arr[i];

            return result;
        }
        // Using Set
        /// <summary>
        /// Another good solution is to use HashSet. Since duplicate elements are not allowed in HashSet,
        /// We can use it to find the unique element present in the array. But this solution use extra space.
        /// - Traverse all element and check if the current element is present in the HashSet:
        ///    -- If Yes, remove the element from the HashSet
        ///    -- If No, Add the element to the HashSet
        /// - At the end we will have only the unique element of the array inside the HashSet and we can return it
        /// --> Time Complexity: O(n)
        /// --> Space Complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int getUniqueElement2(int[] arr)
        {
            int n = arr.Length;
            var arrSet = new HashSet<int>() ;
            for (int i = 0; i < n; i++)
            {
                if (arrSet.Contains(arr[i]))
                    arrSet.Remove(arr[i]);
                else arrSet.Add(arr[i]);
            }

            return arrSet.First();
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 2, 3, 3, 1 };
            int[] arr1 = { 2, 3, 5, 4, 5, 3, 4 };          
            int[] arr2 = { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            int[] arr3 = { 7, 9, 6, 8, 3, 7, 8, 6, 9 };

            Console.WriteLine("Element occurring once in the array using XOR is " +
                                getUniqueElement1(arr3) + " ");
            Console.WriteLine();

            Console.WriteLine("Element occurring once in the array using HashSet is " +
                                getUniqueElement2(arr3) + " ");
        }
    }
}
