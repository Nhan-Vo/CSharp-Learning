// Learn dictionary in C#

public class learnDict
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);

        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        for (var i = 0; i < myDictionary.Count; i++)
        {
            Console.WriteLine($"Index {i} corresponds to key: {myDictionary.ElementAt(i).Key}");
        }
    }
}

// Dictionary in C#
// Overview
// A Dictionary<TKey, TValue> is a collection of key-value pairs.

//  - Key: Unique identifier for each entry.
//  - Value: Data associated with the key.
//  - Keys must be unique; values can be duplicated.
// Namespace
//  - using System.Collections.Generic;
// Declaration
//  - Dictionary<string, int> dict = new Dictionary<string, int>();
// Common Operations:
// Add Elements:
// - dict.Add("Apple", 1);
// - dict["Banana"] = 2; // Alternative way
// Access Elements
    // int value = dict["Apple"]; // Throws KeyNotFoundException if key doesn't exist
// Check if Key Exists
    // if (dict.ContainsKey("Apple"))
    // {
    //     // Key exists
    // }
// Remove Elements
    // dict.Remove("Apple");
// Iterate Dictionary
    // foreach (var item in dict)
    // {
    //     Console.WriteLine($"{item.Key}: {item.Value}");
    // }
// Count Elements
    // int count = dict.Count;
// Clear Dictionary
    // dict.Clear();
// Get Value Safely
    // if (dict.TryGetValue("Apple", out int value))
    // {
    //     Console.WriteLine(value);
    // }
// Keys and Values Collections
    // var keys = dict.Keys;     // IEnumerable<string>
    // var values = dict.Values; // IEnumerable<int>
// Indexing
// Dictionaries are not ordered.
// To access by index, use ElementAt (requires using System.Linq;):
    // var key = dict.ElementAt(0).Key;
    // var value = dict.ElementAt(0).Value;
// Summary Table
// Operation	Example	                        Description
// Add	        dict.Add("A", 1);	            Add key-value pair
// Access	    dict["A"]	                    Get value by key
// Remove	    dict.Remove("A");	            Remove by key
// ContainsKey	dict.ContainsKey("A")	        Check if key exists
// TryGetValue	dict.TryGetValue("A", out v)	Safe get value
// Iterate	    foreach (var kv in dict)	    Loop through all pairs
// Count	    dict.Count	                    Number of pairs
// Clear	    dict.Clear()	                Remove all pairs

// Notes
// Keys must be unique; adding a duplicate key throws an exception.
// Values can be duplicated.
// Dictionary is fast for lookup, add, and remove operations.
// Dictionary is a powerful and commonly used collection for mapping keys to values in C#.