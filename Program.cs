using System;

namespace HashingOutCollections
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Title("ICE Task 2 – Parts 2–4 (Dictionaries & Sets) – Menu App");

            bool exit = false;
            while (!exit)
            {
                switch (ShowMenuAndReadChoice())
                {
                    case "1":
                        Task1.Run();
                        break;
                    case "2":
                        Task2.Run();
                        break;
                    case "3":
                        Task3.Run();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Goodbye! 👋");
                        break;
                    default:
                        Console.WriteLine("Unknown option. Please choose 1, 2, 3 or 0.");
                        break;
                }
                if (!exit) Pause();
            }
        }

        // ---------------- MENU ----------------
        private static string ShowMenuAndReadChoice()
        {
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("=========");
            Console.WriteLine("1) Task 2 – Dictionary of Student IDs → Names");
            Console.WriteLine("2) Task 3 – HashSet of Unique Course Codes");
            Console.WriteLine("3) Task 4 – Set Operations (Math vs Science)");
            Console.WriteLine("0) Exit");
            Console.Write("Select an option: ");
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }

        private static void Title(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(new string('=', text.Length));
            Console.WriteLine();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press ENTER to return to the menu… ");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
