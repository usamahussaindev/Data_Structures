using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a HashSet of integers
        HashSet<int> uniqueNumbers = new HashSet<int>();

        // Adding elements to the HashSet
        uniqueNumbers.Add(5);
        uniqueNumbers.Add(10);
        uniqueNumbers.Add(15);
        uniqueNumbers.Add(20);

        // Adding a duplicate element (it won't be added since HashSet only allows unique elements)
        uniqueNumbers.Add(10);

        // Check if an element exists in the HashSet
        bool contains25 = uniqueNumbers.Contains(25); // false
        bool contains20 = uniqueNumbers.Contains(20); // true

        Console.WriteLine("HashSet elements:");
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Does the HashSet contain 25? {contains25}");
        Console.WriteLine($"Does the HashSet contain 20? {contains20}");
    }
}
