namespace AdventOfCode.Day
{
    internal class Day1
    {
        public static string Solve(string[] input)
        {
            // Pre-define variables for sorting.
            var total = 0;
            var calorieSums = new List<int>();
            var highestCalorieSums = new List<int>();

            // Loop through each calorie value.
            foreach (var value in input)
            {
                // Check whether the line is empty.
                if (!int.TryParse(value, out int result))
                {
                    // Add the current total to the list.
                    calorieSums.Add(total);

                    // Reset the total.
                    total = 0;

                    continue;
                }

                // Add the value to the current total.
                total += int.Parse(value);
            }

            // Loop until we have three highest totals.
            while (highestCalorieSums.Count < 3)
            {
                // Add the highest remaining total to the list.
                highestCalorieSums.Add(calorieSums.Max());

                // Remove the total we've just added so we don't re-use it.
                calorieSums.RemoveAt(calorieSums.IndexOf(calorieSums.Max()));
            }

            return $"Part 1: {highestCalorieSums.Max()}\nPart 2: {highestCalorieSums.Sum()}";
        }
    }
}