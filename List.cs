using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbersList = new List<int>();

        // Add elements to the list
        numbersList.Add(10);
        numbersList.Add(20);
        numbersList.Add(30);

        // You can also initialize a list with values
        List<int> otherNumbersList = new List<int> { 5, 15, 25, 35 };

        // Access elements by index
        Console.WriteLine("Element at index 0: " + numbersList[0]); // Output: 10

        // Modify elements by index
        numbersList[1] = 50;

        // Iterate through the list using a foreach loop
        Console.WriteLine("Iterating through numbersList:");
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }
        // Output:
        // 10
        // 50
        // 30

        // Find elements in the list
        int indexOf30 = numbersList.IndexOf(30);
        Console.WriteLine("Index of 30: " + indexOf30); // Output: 2

        // Remove elements from the list
        numbersList.Remove(50);
        Console.WriteLine("After removing 50:");
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }
        // Output:
        // 10
        // 30

        // Check if the list contains an element
        bool contains10 = numbersList.Contains(10);
        Console.WriteLine("List contains 10: " + contains10); // Output: True

        // Get the number of elements in the list
        int count = numbersList.Count;
        Console.WriteLine("Number of elements in the list: " + count); // Output: 2

        // Clear all elements from the list
        numbersList.Clear();
        Console.WriteLine("After clearing the list, Count: " + numbersList.Count); // Output: 0
    }
}
