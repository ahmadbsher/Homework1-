// HackerRank: Encryption (Medium)
// https://www.hackerrank.com/challenges/encryption/problem
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.In.ReadToEnd();
        StringBuilder cleaned = new StringBuilder();
        foreach (char ch in input)
            if (!char.IsWhiteSpace(ch)) cleaned.Append(ch);

        string text = cleaned.ToString();
        int columns = (int)Math.Ceiling(Math.Sqrt(text.Length));
        List<string> groups = new List<string>();
        for (int c = 0; c < columns; c++)
        {
            StringBuilder group = new StringBuilder();
            for (int pos = c; pos < text.Length; pos += columns) group.Append(text[pos]);
            if (group.Length > 0) groups.Add(group.ToString());
        }
        Console.WriteLine(string.Join(" ", groups));
    }
}
