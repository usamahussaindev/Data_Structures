using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peek at the top element without removing it
        int topElement = stack.Peek();
        Console.WriteLine("Top element: " + topElement);

        // Pop elements from the stack
        int poppedElement1 = stack.Pop();
        int poppedElement2 = stack.Pop();

        Console.WriteLine("Popped elements: " + poppedElement1 + ", " + poppedElement2);

        // Check if the stack is empty
        bool isEmpty = stack.Count == 0;

        Console.WriteLine("Is the stack empty? " + isEmpty);
    }
}
