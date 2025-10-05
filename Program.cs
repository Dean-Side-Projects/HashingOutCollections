using System;
using System.Collections.Generic;

namespace HashingOutCollections
{
    // ONE FILE that answers all practical tasks (2, 3, and 4)
    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Title("ICE Task 2 – Practical (Dictionaries & Sets)");

            // ---------------- Task 1: Dictionary (StudentID -> Name) ----------------
            Section("Task 1: Dictionary of Student IDs → Names");
            var students = new Dictionary<string, string>
            {
                ["ST1001"] = "Alice Mthembu",
                ["ST1002"] = "Bongani Nkosi",
                ["ST1003"] = "Chloe Daniels",
                ["ST1004"] = "Devan Pillay",
                ["ST1005"] = "Esi Okoye"
            };
            PrintDictionary(students);

            // ---------------- Task 3: HashSet (Unique Course Codes) ----------------
            Section("Task 3: HashSet of Unique Course Codes");
            // OrdinalIgnoreCase treats "PROG7311" and "prog7311" as the same
            var courseCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "PROG7311", "PROG7312", "INSY6212", "IRIT7311", "MATH3000", "prog7311"
            };
            PrintSet(courseCodes, "Course Codes");

            // ---------------- Task 4: Set Operations ----------------
            Section("Task 4: Set Operations – Math vs Science");

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

            // Students in both classes (intersection)
            var both = new HashSet<string>(math);
            both.IntersectWith(science);
            PrintSet(both, "Both Classes (Intersection)");

            // Students only in Math (difference)
            var onlyMath = new HashSet<string>(math);
            onlyMath.ExceptWith(science);
            PrintSet(onlyMath, "Only in Math (Difference)");

            // All students (union)
            var all = new HashSet<string>(math);
            all.UnionWith(science);
            PrintSet(all, "All Students (Union)");

            Console.WriteLine("\nDone. Press any key to exit…");
            Console.ReadKey();
        }

        // ---------------- helpers ----------------
        private static void Title(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(new string('=', text.Length));
            Console.WriteLine();
        }

        private static void Section(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine(new string('-', text.Length));
        }

        private static void PrintDictionary(Dictionary<string, string> dict)
        {
            Console.WriteLine("Student ID  →  Name");
            Console.WriteLine(new string('-', 36));
            foreach (var kvp in dict)
                Console.WriteLine($"{kvp.Key,-10} →  {kvp.Value}");
            Console.WriteLine();
        }

        private static void PrintSet(HashSet<string> set, string title)
        {
            Console.WriteLine($"{title} (count={set.Count})");
            Console.WriteLine(new string('-', Math.Max(8, title.Length + 15)));
            foreach (var item in set)
                Console.WriteLine($"• {item}");
            Console.WriteLine();
        }
    }
}
