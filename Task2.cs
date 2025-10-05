using System;
using System.Collections.Generic;

namespace HashingOutCollections
{
    /// <summary>
    /// Task 2: Working with Sets – HashSet of unique course codes.
    /// Shows: automatic de-duplication via hashing + equality, Add result.
    /// </summary>
    public static class Task2
    {
        public static void Run()
        {
            Section("Task 2: HashSet of Unique Course Codes");
            Console.WriteLine("We’ll create a HashSet<string> for course codes. HashSet prevents duplicates automatically\n" +
                              "by using hashing + equality. Membership checks/insertions are ~O(1) on average.\n");

            var courseCodes = BuildCourseCodes();

            Console.WriteLine("Initial set (note: a deliberate duplicate was included during construction):");
            PrintSet(courseCodes, "Course Codes");

            Console.WriteLine("Try adding duplicate 'PROG7311' again:");
            bool added = courseCodes.Add("PROG7311");
            Console.WriteLine($"Add returned: {added}  (false means it was already present)\n");

            Console.WriteLine("Use cases for HashSet: de-dup input, allow/deny lists, fast membership checks, tag flags.");
        }

        private static HashSet<string> BuildCourseCodes() => new(StringComparer.OrdinalIgnoreCase)
        {
            "PROG7311",
            "PROG7312",
            "INSY6212",
            "IRIT7311",
            "MATH3000",
            "prog7311" // duplicate of PROG7311 (case-insensitive comparer)
        };

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
