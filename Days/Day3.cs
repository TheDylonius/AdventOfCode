namespace AdventOfCode.Days
{
    internal class Day3
    {
        public static string Solve(string[] input)
        {
            var total = 0;
            var compartments = new List<string>();
            var commonCharacters = new List<char>();

            // Loop through each line (rucksack) in the input.
            foreach (var rucksack in input)
            {
                // Add each half line as a separate compartment.
                compartments.Add(rucksack[..(rucksack.Length / 2)]);
                compartments.Add(rucksack[(rucksack.Length / 2)..]);
            }

            // Loop through all the compartments.
            for (var i = 0; i < compartments.Count; i++)
            {
                // Check whether the current compartment is even.
                if (i != 0 && i % 2 != 0)
                    continue;

                // Loop through each item within the current compartment.
                foreach (var item in compartments[i])
                {
                    // Check whether the next compartment contains the current item.
                    if (i < compartments.Count && compartments[i + 1].Contains(item))
                    {
                        // Add the item to the list of common characters.
                        commonCharacters.Add(item);

                        // Skip to the next compartment.
                        break;
                    }
                }
            }

            // Loop through each item in the common items list.
            foreach (var character in commonCharacters)
                // Add the numeric value (a = 1, b = 2, A = 27, B = 28, etc.) to the total.
                total += GetCharacterIndex(character);
            
            // Return the results for both part 1 and part 2.
            return $"Part 1: {total}\nPart 2: {""}";
        }

        private static int GetCharacterIndex(char character)
        {
            // Set a constant string of all alphabetic characters.
            const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Return the numerical value for the provided character.
            return alphabet.IndexOf(character) + 1;
        }
    }
}