// HackerRank: Climbing the Leaderboard (Medium)
// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int index = 0;
        int n = int.Parse(tokens[index++]);
        List<int> distinct = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int score = int.Parse(tokens[index++]);
            if (distinct.Count == 0 || distinct[distinct.Count - 1] != score) distinct.Add(score);
        }
        int m = int.Parse(tokens[index++]);
        for (int i = 0; i < m; i++)
        {
            int score = int.Parse(tokens[index++]);
            // Binary search in descending order for first value <= score.
            int low = 0, high = distinct.Count;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (distinct[mid] > score) low = mid + 1;
                else high = mid;
            }
            Console.WriteLine(low + 1);
        }
    }
}
