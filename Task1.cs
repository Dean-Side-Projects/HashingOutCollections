using System;
using System.Collections.Generic;

namespace HashingOutCollections
{
    /// <summary>
    /// Task 1: Working with Dictionaries – student ID -> name
    /// Shows: Add/TryAdd, indexer overwrite, TryGetValue, and printing.
    /// </summary>
    public static class Task1
    {
        public static void Run()
        {
            Section("Task 1: Dictionary of Student IDs → Names");
            Console.WriteLine("We’ll create a Dictionary<string, string> that maps a unique Student ID to a name.\n" +
                              "Dictionaries are ideal when you have an ID and need a fast lookup (~O(1) average).");

            var students = BuildStudentsDictionary();

            Console.WriteLine("\nCurrent dictionary:");
            PrintDictionary(students);

            Console.WriteLine("Demonstrate safe add (TryAdd) with existing key 'ST1001':");
            bool added = students.TryAdd("ST1001", "Someone Else");
            Console.WriteLine($"TryAdd returned: {added}  (false means the key already exists)\n");

            Console.WriteLine("Update an existing value using the indexer: students[\"ST1003\"] = \"Chloe Daniels (Updated)\"");
            students["ST1003"] = "Chloe Daniels (Updated)";
            PrintDictionary(students);

            Console.WriteLine("Safe lookup with TryGetValue(\"ST1002\"):");
            if (students.TryGetValue("ST1002", out string name))
                Console.WriteLine($"Found: ST1002 → {name}\n");
            else
                Console.WriteLine("ST1002 not found.\n");

            Notes();
        }

        private static Dictionary<string, string> BuildStudentsDictionary() => new()
        {
            ["ST1001"] = "Alice Mthembu",
            ["ST1002"] = "Bongani Nkosi",
            ["ST1003"] = "Chloe Daniels",
            ["ST1004"] = "Devan Pillay",
            ["ST1005"] = "Esi Okoye"
        };

        private static void PrintDictionary(Dictionary<string, string> dict)
        {
            Console.WriteLine("Student ID  →  Name");
            Console.WriteLine(new string('-', 36));
            foreach (var kvp in dict)
                Console.WriteLine($"{kvp.Key,-10} →  {kvp.Value}");
            Console.WriteLine();
        }

        private static void Section(string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));
        }

        private static void Notes()
        {
            Console.WriteLine("Notes:");
            Console.WriteLine("• Dictionary keys must be unique; Add on a duplicate throws. TryAdd returns false.");
            Console.WriteLine("• Indexer (dict[key] = value) overwrites the existing value for that key.");
            Console.WriteLine("• TryGetValue avoids exceptions on missing keys.");
        }
    }
}
