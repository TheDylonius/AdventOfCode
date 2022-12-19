namespace AdventOfCode.Day
{
    internal class Day2
    {
        public static string Solve(string[] input)
        {
            // Get opponent's and recommended moves (from input).
            var opponentMoves = new List<char>();
            var recommendedMoves = new List<char>();

            // Initialise score for the strategy guide.
            var partOneScores = new List<int>();
            var partTwoScores = new List<int>();

            // Loop through each line in the input file.
            foreach (var line in input)
            {
                // Get the lists of each player's moves.
                opponentMoves.Add(line[0]);
                recommendedMoves.Add(line[2]);
            }

            // Loop through each of the moves.
            for (var i = 0; i < opponentMoves.Count; i++)
            {
                // Pre-define the current round score.
                // Reset the current round's score.
                int currentRoundScore = 0;
                int partTwoScore = 0;

                // Check what the recommended move is.
                switch (recommendedMoves[i])
                {
                    // Add the relevant points.
                    case 'X': currentRoundScore += 1; break;
                    case 'Y': currentRoundScore += 2; partTwoScore += 3; break;
                    case 'Z': currentRoundScore += 3; partTwoScore += 6; break;
                }

                // Check whether the current round is a draw.
                if ((opponentMoves[i] == 'A' && recommendedMoves[i] == 'X') || (opponentMoves[i] == 'B' && recommendedMoves[i] == 'Y') || (opponentMoves[i] == 'C' && recommendedMoves[i] == 'Z'))
                    currentRoundScore += 3;

                // Check whether the current round has been won.
                else if ((opponentMoves[i] == 'A' && recommendedMoves[i] == 'Y') || (opponentMoves[i] == 'B' && recommendedMoves[i] == 'Z') || (opponentMoves[i] == 'C' && recommendedMoves[i] == 'X'))
                    currentRoundScore += 6;

                // Check whether the recommended move is rock.
                if ((opponentMoves[i] == 'A' && recommendedMoves[i] == 'Y') || (opponentMoves[i] == 'B' && recommendedMoves[i] == 'X') || (opponentMoves[i] == 'C' && recommendedMoves[i] == 'Z'))
                    partTwoScore += 1;

                // Check whether the recommended move is paper.
                if ((opponentMoves[i] == 'A' && recommendedMoves[i] == 'Z') || (opponentMoves[i] == 'B' && recommendedMoves[i] == 'Y') || (opponentMoves[i] == 'C' && recommendedMoves[i] == 'X'))
                    partTwoScore += 2;

                // Check whether the recommended move is scissors.
                if ((opponentMoves[i] == 'A' && recommendedMoves[i] == 'X') || (opponentMoves[i] == 'B' && recommendedMoves[i] == 'Z') || (opponentMoves[i] == 'C' && recommendedMoves[i] == 'Y'))
                    partTwoScore += 3;

                // Add the current round's score to the score list.
                partOneScores.Add(currentRoundScore);
                partTwoScores.Add(partTwoScore);
            }

            return $"Part 1: {partOneScores.Sum()}\nPart 2: {partTwoScores.Sum()}";
        }
    }
}