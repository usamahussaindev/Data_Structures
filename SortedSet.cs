using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a SortedSet of integers
        SortedSet<int> sortedNumbers = new SortedSet<int>();

        // Add elements to the SortedSet
        sortedNumbers.Add(5);
        sortedNumbers.Add(2);
        sortedNumbers.Add(8);
        sortedNumbers.Add(1);

        // The elements will be automatically sorted
        Console.WriteLine("SortedSet elements:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }

        // Check if an element exists in the SortedSet
        bool exists = sortedNumbers.Contains(8);
        Console.WriteLine($"Does 8 exist in the SortedSet? {exists}");

        // Remove an element
        sortedNumbers.Remove(2);

        Console.WriteLine("After removing 2:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
