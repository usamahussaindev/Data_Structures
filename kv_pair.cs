using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a KeyValuePair with a string key and an int value
        KeyValuePair<string, int> person = new KeyValuePair<string, int>("John", 30);

        // Access and display the key and value
        Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");

        // You can also destructure the KeyValuePair
        var (name, age) = person;
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
