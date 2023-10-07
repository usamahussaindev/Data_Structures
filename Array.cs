using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an integer array
        int[] numbers = new int[5];

        // Assign values to array elements
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Access and print array elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        // Calculate the sum of array elements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of array elements: {sum}");

        // Find the maximum element in the array
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"Maximum element in the array: {max}");

        // Search for a specific element in the array
        int searchValue = 30;
        int indexOfValue = Array.IndexOf(numbers, searchValue);
        if (indexOfValue != -1)
        {
            Console.WriteLine($"{searchValue} found at index {indexOfValue}");
        }
        else
        {
            Console.WriteLine($"{searchValue} not found in the array");
        }
    }
}
