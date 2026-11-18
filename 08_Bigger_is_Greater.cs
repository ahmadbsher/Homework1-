// HackerRank: Bigger is Greater (Medium)
// https://www.hackerrank.com/challenges/bigger-is-greater/problem
using System;
using System.Text;

class Program
{
    static string NextPermutation(string word)
    {
        char[] a = word.ToCharArray();
        int i = a.Length - 2;
        while (i >= 0 && a[i] >= a[i + 1]) i--;
        if (i < 0) return "no answer";

        int j = a.Length - 1;
        while (a[j] <= a[i]) j--;
        char temp = a[i]; a[i] = a[j]; a[j] = temp;
        Array.Reverse(a, i + 1, a.Length - i - 1);
        return new string(a);
    }

    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine().Trim());
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < testCases; i++)
            output.AppendLine(NextPermutation(Console.ReadLine().Trim()));
        Console.Write(output.ToString());
    }
}
