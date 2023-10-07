using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store ages by name
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Add entries to the dictionary
        ages["Alice"] = 25;
        ages["Bob"] = 30;
        ages["Charlie"] = 22;

        // Access values by key
        Console.WriteLine("Alice's age: " + ages["Alice"]);
        Console.WriteLine("Bob's age: " + ages["Bob"]);
        Console.WriteLine("Charlie's age: " + ages["Charlie"]);

        // Check if a key exists in the dictionary
        if (ages.ContainsKey("David"))
        {
            Console.WriteLine("David's age: " + ages["David"]);
        }
        else
        {
            Console.WriteLine("David's age is not in the dictionary.");
        }

        // Iterate through the dictionary's keys and values
        foreach (var pair in ages)
        {
            Console.WriteLine(pair.Key + "'s age is " + pair.Value);
        }
    }
}
