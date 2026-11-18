// HackerRank: The Grid Search (Medium)
// https://www.hackerrank.com/challenges/the-grid-search/problem
using System;
using System.Text;

class Program
{
    static bool ContainsPattern(string[] grid, string[] pattern)
    {
        int rows = grid.Length, columns = grid[0].Length;
        int patternRows = pattern.Length, patternCols = pattern[0].Length;
        for (int r = 0; r + patternRows <= rows; r++)
        {
            int from = 0;
            while (from + patternCols <= columns)
            {
                int c = grid[r].IndexOf(pattern[0], from, StringComparison.Ordinal);
                if (c < 0 || c + patternCols > columns) break;

                bool matches = true;
                for (int offset = 1; offset < patternRows; offset++)
                {
                    if (string.CompareOrdinal(grid[r + offset], c, pattern[offset], 0, patternCols) != 0)
                    {
                        matches = false;
                        break;
                    }
                }
                if (matches) return true;
                from = c + 1;
            }
        }
        return false;
    }

    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int at = 0;
        int testCases = int.Parse(tokens[at++]);
        StringBuilder output = new StringBuilder();
        for (int test = 0; test < testCases; test++)
        {
            int r = int.Parse(tokens[at++]);
            int c = int.Parse(tokens[at++]);
            string[] grid = new string[r];
            for (int i = 0; i < r; i++) grid[i] = tokens[at++];
            int pr = int.Parse(tokens[at++]);
            int pc = int.Parse(tokens[at++]);
            string[] pattern = new string[pr];
            for (int i = 0; i < pr; i++) pattern[i] = tokens[at++];
            output.AppendLine(ContainsPattern(grid, pattern) ? "YES" : "NO");
        }
        Console.Write(output.ToString());
    }
}
