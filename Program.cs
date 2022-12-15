using AdventOfCode.Day;

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
            Console.WriteLine($"\nAnswers\n{GetAnswer(day)}");

            // Await input before closing the console.
            //Console.Read();
        }

        private static string GetAnswer(int day)
        {
            string[] input;

            // Check whether input exists for the day.
            if (!File.Exists($@"C:\Development\Projects\Personal\AdventOfCode\Inputs\day{day}.txt"))
                return "This day has not yet been developed.";

            // Get the input for the requested day.
            input = File.ReadAllLines($@"C:\Development\Projects\Personal\AdventOfCode\Inputs\day{day}.txt");

            // Check which day the user requested.
            switch (day)
            {
                case 1: return Day1.Solve(input);
                case 2: return Day2.Solve(input);
            }

            // Inform the user that the requested day doesn't exist.
            return "This day has not yet been developed.";
        }

        private static int GetIntAsInput()
        {
            var result = 0;

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