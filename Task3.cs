using System;
using System.Collections.Generic;

namespace HashingOutCollections
{
    /// <summary>
    /// Task 3: Set operations on two classes (Math vs Science).
    /// Shows: IntersectWith, ExceptWith, UnionWith + friendly explanations.
    /// </summary>
    public static class Task3
    {
        public static void Run()
        {
            Section("Task 3: Set Operations – Math vs Science");
            Console.WriteLine("We’ll build two sets of student names and compute:\n" +
                              "• Intersection (both classes)\n" +
                              "• Difference (only in Math)\n" +
                              "• Union (all unique students)\n");

            var math = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Alice", "Bongani", "Chloe", "Devan", "Esi"
            };

            var science = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Chloe", "Esi", "Farah", "Gareth"
            };

            PrintSet(math, "Math Class");
            PrintSet(science, "Science Class");

            // 1) Intersection: names in BOTH sets
            var both = new HashSet<string>(math);
            both.IntersectWith(science);
            PrintSet(both, "Both Classes (Intersection: Math ∩ Science)");

            // 2) Difference: names in Math that are NOT in Science
            var onlyMath = new HashSet<string>(math);
            onlyMath.ExceptWith(science);
            PrintSet(onlyMath, "Only in Math (Difference: Math − Science)");

            // 3) Union: all unique names across both sets
            var all = new HashSet<string>(math);
            all.UnionWith(science);
            PrintSet(all, "All Students (Union: Math ∪ Science)");

            Console.WriteLine("Notes:");
            Console.WriteLine("- Intersection = elements common to BOTH sets.");
            Console.WriteLine("- Difference   = elements from the first set that are NOT in the second.");
            Console.WriteLine("- Union        = all unique elements from both sets (no duplicates).");
        }

        private static void PrintSet(HashSet<string> set, string title)
        {
            Console.WriteLine($"{title} (count={set.Count})");
            Console.WriteLine(new string('-', Math.Max(8, title.Length + 15)));
            foreach (var item in set)
                Console.WriteLine($"• {item}");
            Console.WriteLine();
        }

        private static void Section(string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));
        }
    }
}
