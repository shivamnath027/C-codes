// Problem Statement Second largest Element in an array (Sorted and without Sorted)
using System;

namespace main
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of Array: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Code here
            int index=0, max = 0;
            for(int i = 0; i < n; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            max = int.MinValue;
            for (int i = 0; i < n ; i++)
            {
                if (arr[i] > max && i!=index)
                {
                    max = arr[i];
                }
            }
            if (max == int.MinValue)
            {
                Console.WriteLine("No second largest element exists.");
            }
            else
            {
                Console.WriteLine("Second largest element is: " + max);
            }
        }
    }
}