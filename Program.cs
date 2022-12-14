using System;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day: ");
            var day = GetIntAsInput();

            Console.Write("Input: ");
            var input = GetIntAsInput();

            Day1();
        }

        private static void Day1(int calories)
        {
            
        }

        private static int GetIntAsInput()
        {
            var result = 0;

            string? input = Console.ReadLine();

            while (!int.TryParse(input, out result))
            {
                input = Console.ReadLine();
                Console.Clear();
            }

            return result;
        }
    }
}