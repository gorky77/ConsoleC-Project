using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of strings that contains at least two identical strings.
        List<string> itemList = new List<string>()
        {
            "Apple",
            "Banana",
            "Orange",
            "Apple", // Duplicate
            "Grapes",
            "Banana" // Duplicate
        };

        // Create a HashSet to keep track of unique items.
        HashSet<string> uniqueItems = new HashSet<string>();

        // Iterate through each item in the list.
        foreach (string item in itemList)
        {
            // Check if the item is already in the HashSet (meaning it's a duplicate).
            if (uniqueItems.Contains(item))
            {
                // Display a message showing the string and that it is a duplicate.
                Console.WriteLine(item + " - this item is a duplicate");
            }
            else
            {
                // Display a message showing the string and that it is unique.
                Console.WriteLine(item + " - this item is unique");
                // Add the item to the HashSet.
                uniqueItems.Add(item);
            }
        }

        Console.ReadLine();
    }
}

