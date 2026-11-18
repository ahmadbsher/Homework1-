// HackerRank: Organizing Containers of Balls (Medium)
// https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
using System;

class Program
{
    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int at = 0;
        int queries = int.Parse(tokens[at++]);
        for (int query = 0; query < queries; query++)
        {
            int n = int.Parse(tokens[at++]);
            long[] capacities = new long[n];
            long[] counts = new long[n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    long amount = long.Parse(tokens[at++]);
                    capacities[r] += amount;
                    counts[c] += amount;
                }
            }
            Array.Sort(capacities);
            Array.Sort(counts);
            bool possible = true;
            for (int i = 0; i < n; i++)
            {
                if (capacities[i] != counts[i]) { possible = false; break; }
            }
            Console.WriteLine(possible ? "Possible" : "Impossible");
        }
    }
}
