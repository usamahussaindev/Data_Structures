using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new queue to store strings
        Queue<string> queue = new Queue<string>();

        // Enqueue (add) items to the queue
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Cherry");

        // Display the items in the queue
        Console.WriteLine("Queue elements:");
        foreach (string fruit in queue)
        {
            Console.WriteLine(fruit);
        }

        // Dequeue (remove) an item from the front of the queue
        string dequeuedItem = queue.Dequeue();
        Console.WriteLine("\nDequeued item: " + dequeuedItem);

        // Peek at the front item without removing it
        string frontItem = queue.Peek();
        Console.WriteLine("Front item (peek): " + frontItem);

        // Display the updated queue
        Console.WriteLine("\nUpdated queue elements:");
        foreach (string fruit in queue)
        {
            Console.WriteLine(fruit);
        }
    }
}
