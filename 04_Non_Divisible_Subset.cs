// HackerRank: Non-Divisible Subset (Medium)
// https://www.hackerrank.com/challenges/non-divisible-subset/problem
using System;

class Program
{
    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int index = 0;
        int n = int.Parse(tokens[index++]);
        int k = int.Parse(tokens[index++]);
        int[] frequency = new int[k];
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(tokens[index++]);
            frequency[value % k]++;
        }
        int result = frequency[0] > 0 ? 1 : 0;
        for (int remainder = 1; remainder <= k / 2; remainder++)
        {
            int complement = k - remainder;
            if (remainder == complement) result += frequency[remainder] > 0 ? 1 : 0;
            else result += Math.Max(frequency[remainder], frequency[complement]);
        }
        Console.WriteLine(result);
    }
}
