// HackerRank: Forming a Magic Square (Medium)
// https://www.hackerrank.com/challenges/magic-square-forming/problem
using System;

class Program
{
    static readonly int[][] Squares = {
        new[] { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
        new[] { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
        new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
        new[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
        new[] { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
        new[] { 4, 3, 8, 9, 5, 1, 2, 7, 6 },
        new[] { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
        new[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 }
    };

    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int[] values = new int[9];
        for (int i = 0; i < 9; i++) values[i] = int.Parse(tokens[i]);

        int best = int.MaxValue;
        foreach (int[] square in Squares)
        {
            int cost = 0;
            for (int i = 0; i < 9; i++) cost += Math.Abs(values[i] - square[i]);
            best = Math.Min(best, cost);
        }
        Console.WriteLine(best);
    }
}
