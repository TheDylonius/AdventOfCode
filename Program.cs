using AdventOfCode.Day;
using AdventOfCode.Days;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to specify which day.
            Console.Write("Day: ");
            var day = GetIntAsInput();

            // Provide the answer for the specified day.
            Console.WriteLine($"\nAnswers\n{GetAnswers(day)}");
        }

        private static string GetAnswers(int day)
        {
            string[] input;

            // Check whether input exists for the day.
            if (!File.Exists($"{Path.GetFullPath(@"..\..\..\")}\\Inputs\\day{day}.txt"))
                return "This day has not yet been developed.";

            // Get the input for the requested day.
            input = File.ReadAllLines($"{Path.GetFullPath(@"..\..\..\")}\\Inputs\\day{day}.txt");

            // Check which day the user requested.
            switch (day)
            {
                case 1: return Day1.Solve(input);
                case 2: return Day2.Solve(input);
                case 3: return Day3.Solve(input);
                default:
                    break;
            }

            return "This day has not yet been developed.";
        }

        private static int GetIntAsInput()
        {
            int result;

            // Get initial input from the user.
            string? input = Console.ReadLine();

            // Repeatedly ask for input until provided.
            while (!int.TryParse(input, out result))
            {
                input = Console.ReadLine();
            }

            // Return the integer (once provided).
            return result;
        }
    }
}