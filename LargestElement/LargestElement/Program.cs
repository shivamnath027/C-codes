// See https://aka.ms/new-console-template for more information

// Problem Statement Largest Element in an Array

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
            int[] arr = new int [n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            foreach(int i in arr){
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Largest= {max}");
        }
    }
}