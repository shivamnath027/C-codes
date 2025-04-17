using System.Collections.Generic;
using System.Globalization;
namespace L_and_d
{
    class learn
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(5);
            num.Add(4);
            // Inbuilt functions of List
            num.Remove(5); // Removes the first occurrence of 5
            num.RemoveAt(0); // Removes the element at index 0
            num.Clear(); // Removes all elements from the list
            Console.WriteLine(num.Count);// Prints the number of elements in the list
            Console.WriteLine(num.Contains(4)); // Checks if the list contains 4
            Console.WriteLine(num.IndexOf(4)); // Returns the index of the first occurrence of 4
            Console.WriteLine(num.LastIndexOf(4)); // Returns the index of the last occurrence of 4
            Console.WriteLine(num.Capacity); // Returns the capacity of the list

            // Dictionary
            Dictionary <int,string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            //Inbuilt functions of Dictionary
            dict.Remove(2); // Removes the key-value pair with key 2
            dict.Clear(); // Removes all key-value pairs from the dictionary
            Console.WriteLine(dict.Count); // Prints the number of key-value pairs in the dictionary
            Console.WriteLine(dict.ContainsKey(1)); // Checks if the dictionary contains the key 1
            Console.WriteLine(dict.ContainsValue("one")); // Checks if the dictionary contains the value "one"
            Console.WriteLine(dict.TryGetValue(1, out string value)); // Tries to get the value of key 1
                                                                      // If the key is found, value will be set to the value of key 1 and the method will return true
                                                                      // else, value will be set to null and the method will return false
            Console.WriteLine(value); // Prints the value of key 1  

            Console.WriteLine(dict.Keys); // Prints the keys of the dictionary
            Console.WriteLine(dict.Values); // Prints the values of the dictionary
            // Iterating through the dictionary
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
            //using for loop
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: " + dict.Keys.ElementAt(i) + ", Value: " + dict.Values.ElementAt(i));
            }

            // Iterating through the dictionary using LINQ
            var query = from kvp in dict
                        where kvp.Key > 1
                        select kvp;
            foreach (var kvp in query)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
            
        }
    }
}