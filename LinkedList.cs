using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new linked list of integers
        LinkedList<int> linkedList = new LinkedList<int>();

        // Add elements to the linked list
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);

        // Display the elements in the linked list
        Console.WriteLine("Linked List Elements:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }

        // Remove an element from the linked list
        linkedList.Remove(2);

        // Display the modified linked list
        Console.WriteLine("\nLinked List After Removing 2:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }

        // Add an element at the beginning of the linked list
        linkedList.AddFirst(0);

        // Display the modified linked list
        Console.WriteLine("\nLinked List After Adding 0 at the Beginning:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}
