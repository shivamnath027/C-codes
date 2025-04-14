// Problem Statement Check if Array is Sorted or Not
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
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    
                }
            }

        }
    }
}